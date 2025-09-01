/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 сентября 2025 11:04:53
 * Version: 1.0.10
 */

#if CSHARP_7_OR_LATER || (UNITY_2018_3_OR_NEWER && (NET_STANDARD_2_0 || NET_4_6))
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniRx.InternalUtil
{
    internal interface ICancellableTaskCompletionSource
    {
        bool TrySetException(Exception exception);
        bool TrySetCanceled();
    }

    internal class CancellableTaskCompletionSource<T> : TaskCompletionSource<T>, ICancellableTaskCompletionSource
    {
       
    }
}

#endif