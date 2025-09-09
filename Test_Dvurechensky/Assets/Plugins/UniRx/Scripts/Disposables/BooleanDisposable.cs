/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 сентября 2025 11:10:33
 * Version: 1.0.18
 */

using System;
using System.Collections;

namespace UniRx
{
    public sealed class BooleanDisposable : IDisposable, ICancelable
    {
        public bool IsDisposed { get; private set; }

        public BooleanDisposable()
        {

        }

        internal BooleanDisposable(bool isDisposed)
        {
            IsDisposed = isDisposed;
        }

        public void Dispose()
        {
            if (!IsDisposed) IsDisposed = true;
        }
    }
}