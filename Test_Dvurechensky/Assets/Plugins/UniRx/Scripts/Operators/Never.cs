/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 декабря 2025 11:18:54
 * Version: 1.0.104
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