/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 февраля 2026 09:41:14
 * Version: 1.0.190
 */

using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace UniRx.Diagnostics
{
    public class ObservableLogger : IObservable<LogEntry>
    {
        static readonly Subject<LogEntry> logPublisher = new Subject<LogEntry>();

        public static readonly ObservableLogger Listener = new ObservableLogger();

        private ObservableLogger()
        {

        }

        public static Action<LogEntry> RegisterLogger(Logger logger)
        {
            if (logger.Name == null) throw new ArgumentNullException("logger.Name is null");

            return logPublisher.OnNext;
        }

        public IDisposable Subscribe(IObserver<LogEntry> observer)
        {
            return logPublisher.Subscribe(observer);
        }
    }
}