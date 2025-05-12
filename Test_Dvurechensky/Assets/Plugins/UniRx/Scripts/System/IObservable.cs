/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 08:07:05
 * Version: 1.0.1
 */

// defined from .NET Framework 4.0 and NETFX_CORE

using System;

#if !(NETFX_CORE || NET_4_6 || NET_STANDARD_2_0 || UNITY_WSA_10_0)

namespace UniRx
{
    public interface IObservable<T>
    {
        IDisposable Subscribe(IObserver<T> observer);
    }
}

#endif

namespace UniRx
{
    public interface IGroupedObservable<TKey, TElement> : IObservable<TElement>
    {
        TKey Key { get; }
    }
}