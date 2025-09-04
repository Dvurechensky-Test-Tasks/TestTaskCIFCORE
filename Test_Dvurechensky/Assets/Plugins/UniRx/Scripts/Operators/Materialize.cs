/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 сентября 2025 08:07:37
 * Version: 1.0.13
 */

using System;

namespace UniRx.Operators
{
    internal class MaterializeObservable<T> : OperatorObservableBase<Notification<T>>
    {
        readonly IObservable<T> source;

        public MaterializeObservable(IObservable<T> source)
            : base(source.IsRequiredSubscribeOnCurrentThread())
        {
            this.source = source;
        }

        protected override IDisposable SubscribeCore(IObserver<Notification<T>> observer, IDisposable cancel)
        {
            return new Materialize(this, observer, cancel).Run();
        }

        class Materialize : OperatorObserverBase<T, Notification<T>>
        {
            readonly MaterializeObservable<T> parent;

            public Materialize(MaterializeObservable<T> parent, IObserver<Notification<T>> observer, IDisposable cancel)
                : base(observer, cancel)
            {
                this.parent = parent;
            }

            public IDisposable Run()
            {
                return parent.source.Subscribe(this);
            }

            public override void OnNext(T value)
            {
                observer.OnNext(Notification.CreateOnNext(value));
            }

            public override void OnError(Exception error)
            {
                observer.OnNext(Notification.CreateOnError<T>(error));
                try { observer.OnCompleted(); } finally { Dispose(); }
            }

            public override void OnCompleted()
            {
                observer.OnNext(Notification.CreateOnCompleted<T>());
                try { observer.OnCompleted(); } finally { Dispose(); }
            }
        }
    }
}