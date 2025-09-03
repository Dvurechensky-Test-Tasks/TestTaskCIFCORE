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