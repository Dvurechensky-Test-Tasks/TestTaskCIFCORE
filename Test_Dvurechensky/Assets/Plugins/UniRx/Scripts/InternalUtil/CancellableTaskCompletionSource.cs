/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 августа 2025 07:05:58
 * Version: 1.0.6
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