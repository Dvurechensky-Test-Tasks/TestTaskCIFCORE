/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 января 2026 17:07:49
 * Version: 1.0.143
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