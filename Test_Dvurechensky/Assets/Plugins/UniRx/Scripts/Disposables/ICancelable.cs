/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 марта 2026 06:50:29
 * Version: 1.0.200
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
