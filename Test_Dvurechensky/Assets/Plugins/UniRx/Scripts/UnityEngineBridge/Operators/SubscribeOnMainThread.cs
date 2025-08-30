/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 августа 2025 08:33:25
 * Version: 1.0.8
 */

using System;

namespace UniRx.Operators
{
    internal class SubscribeOnMainThreadObservable<T> : OperatorObservableBase<T>
    {
        readonly IObservable<T> source;
        readonly IObservable<long> subscribeTrigger;

        public SubscribeOnMainThreadObservable(IObservable<T> source, IObservable<long> subscribeTrigger)
            : base(source.IsRequiredSubscribeOnCurrentThread())
        {
            this.source = source;
            this.subscribeTrigger = subscribeTrigger;
        }

        protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
        {
            var m = new SingleAssignmentDisposable();
            var d = new SerialDisposable();
            d.Disposable = m;

            m.Disposable = subscribeTrigger.SubscribeWithState3(observer, d, source, (_, o, disp, s) =>
            {
                disp.Disposable = s.Subscribe(o);
            });

            return d;
        }
    }
}