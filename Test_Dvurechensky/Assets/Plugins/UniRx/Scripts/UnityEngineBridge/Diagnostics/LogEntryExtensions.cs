/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 января 2026 10:22:21
 * Version: 1.0.139
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace UniRx.Diagnostics
{
    public static partial class LogEntryExtensions
    {
        public static IDisposable LogToUnityDebug(this IObservable<LogEntry> source)
        {
            return source.Subscribe(new UnityDebugSink());
        }
    }
}