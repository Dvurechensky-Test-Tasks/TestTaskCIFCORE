/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 августа 2025 07:38:17
 * Version: 1.0.9
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
