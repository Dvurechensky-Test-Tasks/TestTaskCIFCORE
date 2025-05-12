/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 08:07:05
 * Version: 1.0.1
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