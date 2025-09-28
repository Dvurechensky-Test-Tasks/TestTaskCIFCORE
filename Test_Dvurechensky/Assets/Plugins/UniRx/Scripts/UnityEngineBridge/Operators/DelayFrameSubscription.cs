/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 сентября 2025 21:12:51
 * Version: 1.0.37
 */

using System;

#if UniRxLibrary
using UnityObservable = UniRx.ObservableUnity;
#else
using UnityObservable = UniRx.Observable;
#endif

namespace UniRx.Operators
{
    internal class DelayFrameSubscriptionObservable<T> : OperatorObservableBase<T>
    {
        readonly IObservable<T> source;
        readonly int frameCount;
        readonly FrameCountType frameCountType;

        public DelayFrameSubscriptionObservable(IObservable<T> source, int frameCount, FrameCountType frameCountType)
            : base(source.IsRequiredSubscribeOnCurrentThread())
        {
            this.source = source;
            this.frameCount = frameCount;
            this.frameCountType = frameCountType;
        }

        protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
        {
            var d = new MultipleAssignmentDisposable();
            d.Disposable = UnityObservable.TimerFrame(frameCount, frameCountType)
                .SubscribeWithState3(observer, d, source, (_, o, disp, s) =>
                {
                    disp.Disposable = s.Subscribe(o);
                });

            return d;
        }
    }
}