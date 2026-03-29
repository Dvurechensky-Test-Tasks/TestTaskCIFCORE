/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 марта 2026 11:11:52
 * Version: 1.0.220
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