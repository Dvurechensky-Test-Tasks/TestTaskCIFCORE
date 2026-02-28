/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 февраля 2026 15:54:06
 * Version: 1.0.191
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