/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 января 2026 14:58:24
 * Version: 1.0.135
 */

#if UNITY_METRO

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace UniRx
{
    public static class Thread
    {
        public static void Sleep(TimeSpan wait)
        {
            new System.Threading.ManualResetEvent(false).WaitOne(wait);
        }

        public static void Sleep(int ms)
        {
            new System.Threading.ManualResetEvent(false).WaitOne(ms);
        }
    }
}

#endif