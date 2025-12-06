/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 декабря 2025 15:33:31
 * Version: 1.0.107
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