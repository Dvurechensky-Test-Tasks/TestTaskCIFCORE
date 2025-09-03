/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 сентября 2025 07:55:35
 * Version: 1.0.12
 */

using System;

namespace UniRx.Operators
{
    internal class DeferObservable<T> : OperatorObservableBase<T>
    {
        readonly Func<IObservable<T>> observableFactory;

        public DeferObservable(Func<IObservable<T>> observableFactory)
            : base(false)
        {
            this.observableFactory = observableFactory;
        }

        protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
        {
            observer = new Defer(observer, cancel);

            IObservable<T> source;
            try
            {
                source = observableFactory();
            }
            catch (Exception ex)
            {
                source = Observable.Throw<T>(ex);
            }

            return source.Subscribe(observer);
        }

        class Defer : OperatorObserverBase<T, T>
        {
            public Defer(IObserver<T> observer, IDisposable cancel) : base(observer, cancel)
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