/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 октября 2025 10:56:40
 * Version: 1.0.55
 */

using System;
using System.Collections.Generic;

namespace UniRx.Operators
{
    internal class SubscribeOnObservable<T> : OperatorObservableBase<T>
    {
        readonly IObservable<T> source;
        readonly IScheduler scheduler;

        public SubscribeOnObservable(IObservable<T> source, IScheduler scheduler)
            : base(scheduler == Scheduler.CurrentThread || source.IsRequiredSubscribeOnCurrentThread())
        {
            this.source = source;
            this.scheduler = scheduler;
        }

        protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
        {
            var m = new SingleAssignmentDisposable();
            var d = new SerialDisposable();
            d.Disposable = m;

            m.Disposable = scheduler.Schedule(() =>
            {
                d.Disposable = new ScheduledDisposable(scheduler, source.Subscribe(observer));
            });

            return d;
        }
    }
}