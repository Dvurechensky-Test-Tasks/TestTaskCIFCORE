/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 ноября 2025 14:36:10
 * Version: 1.0.101
 */

using System;
using UniRx.Operators;

namespace UniRx.Operators
{
    internal class AsSingleUnitObservableObservable<T> : OperatorObservableBase<Unit>
    {
        readonly IObservable<T> source;

        public AsSingleUnitObservableObservable(IObservable<T> source)
            : base(source.IsRequiredSubscribeOnCurrentThread())
        {
            this.source = source;
        }

        protected override IDisposable SubscribeCore(IObserver<Unit> observer, IDisposable cancel)
        {
            return source.Subscribe(new AsSingleUnitObservable(observer, cancel));
        }

        class AsSingleUnitObservable : OperatorObserverBase<T, Unit>
        {
            public AsSingleUnitObservable(IObserver<Unit> observer, IDisposable cancel) : base(observer, cancel)
            {
            }

            public override void OnNext(T value)
            {
            }

            public override void OnError(Exception error)
            {
                try { observer.OnError(error); }
                finally { Dispose(); }
            }

            public override void OnCompleted()
            {
                observer.OnNext(Unit.Default);

                try { observer.OnCompleted(); }
                finally { Dispose(); }
            }
        }
    }
}