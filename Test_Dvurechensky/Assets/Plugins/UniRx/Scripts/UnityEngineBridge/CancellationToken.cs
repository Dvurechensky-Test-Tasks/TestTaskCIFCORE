/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 февраля 2026 06:50:27
 * Version: 1.0.169
 */

#if !(NETFX_CORE || NET_4_6 || NET_STANDARD_2_0 || UNITY_WSA_10_0)

using System;

namespace UniRx
{
    public struct CancellationToken
    {
        readonly ICancelable source;

        public static readonly CancellationToken Empty = new CancellationToken(null);
        
        /// <summary>Same as Empty.</summary>
        public static readonly CancellationToken None = new CancellationToken(null);

        public CancellationToken(ICancelable source)
        {
            this.source = source;
        }

        public bool IsCancellationRequested
        {
            get
            {
                return (source == null) ? false : source.IsDisposed;
            }
        }

        public void ThrowIfCancellationRequested()
        {
            if (IsCancellationRequested)
            {
                throw new OperationCanceledException();
            }
        }
    }
}

#endif

