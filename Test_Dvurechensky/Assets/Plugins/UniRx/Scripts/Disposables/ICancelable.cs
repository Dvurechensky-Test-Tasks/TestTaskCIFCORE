/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 сентября 2025 15:28:32
 * Version: 1.0.21
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace UniRx
{
    public interface ICancelable : IDisposable
    {
        bool IsDisposed { get; }
    }
}
