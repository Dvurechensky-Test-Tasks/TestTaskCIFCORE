/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 08:07:05
 * Version: 1.0.1
 */

using System;

namespace UniRx.Operators
{
    internal class ThrowObservable<T> : OperatorObservableBase<T>
    {
        readonly Exception error;
        readonly IScheduler scheduler;

        public ThrowObservable(Exception error, IScheduler scheduler)
            : base(scheduler == Scheduler.CurrentThread)
        {
            this.error = error;
            this.scheduler = scheduler;
        }

        protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
        {
            observer = new Throw(observer, cancel);

            if (scheduler == Scheduler.Immediate)
            {
                observer.OnError(error);
                return Disposable.Empty;
            }
            else
            {
                return scheduler.Schedule(() =>
                {
                    observer.OnError(error);
                    observer.OnCompleted();
                });
            }
        }

        class Throw : OperatorObserverBase<T, T>
        {
            public Throw(IObserver<T> observer, IDisposable cancel)
                : base(observer, cancel)
            {
            }

            public override void OnNext(T value)
            {
                try
                {
                    base.observer.OnNext(value);
                }
                catch
                {
                    Dispose();
                    throw;
                }
            }

            public override void OnError(Exception error)
            {
                try { observer.OnError(error); }
                finally { Dispose(); }
            }

            public override void OnCompleted()
            {
                try { observer.OnCompleted(); }
                finally { Dispose(); }
            }
        }
    }
}
