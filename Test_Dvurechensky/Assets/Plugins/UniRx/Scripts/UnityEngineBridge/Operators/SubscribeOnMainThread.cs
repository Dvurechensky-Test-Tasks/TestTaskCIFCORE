/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 января 2026 11:55:40
 * Version: 1.0.149
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