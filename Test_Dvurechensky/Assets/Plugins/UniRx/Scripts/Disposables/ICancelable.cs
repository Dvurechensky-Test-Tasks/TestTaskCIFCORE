/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 октября 2025 14:19:39
 * Version: 1.0.60
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
