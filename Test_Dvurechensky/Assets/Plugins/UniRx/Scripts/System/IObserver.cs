/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 сентября 2025 06:50:28
 * Version: 1.0.11
 */

// defined from .NET Framework 4.0 and NETFX_CORE

#if !(NETFX_CORE || NET_4_6 || NET_STANDARD_2_0 || UNITY_WSA_10_0)

using System;

namespace UniRx
{
    public interface IObserver<T>
    {
        void OnCompleted();
        void OnError(Exception error);
        void OnNext(T value);
    }
}

#endif