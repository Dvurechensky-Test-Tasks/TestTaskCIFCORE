/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 октября 2025 17:05:47
 * Version: 1.0.70
 */

using System;

namespace UniRx.Operators
{
    internal class NeverObservable<T> : OperatorObservableBase<T>
    {
        public NeverObservable()
            : base(false)
        {
        }

        protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel)
        {
            return Disposable.Empty;
        }
    }

    internal class ImmutableNeverObservable<T> : IObservable<T>, IOptimizedObservable<T>
    {
        internal static ImmutableNeverObservable<T> Instance = new ImmutableNeverObservable<T>();

        public bool IsRequiredSubscribeOnCurrentThread()
        {
            return false;
        }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            return Disposable.Empty;
        }
    }
}