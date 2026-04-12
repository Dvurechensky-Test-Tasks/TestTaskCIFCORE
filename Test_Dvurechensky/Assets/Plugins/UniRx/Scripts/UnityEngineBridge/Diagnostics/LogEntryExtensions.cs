/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 апреля 2026 14:13:56
 * Version: 1.0.234
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