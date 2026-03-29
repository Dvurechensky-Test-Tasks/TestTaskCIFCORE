/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 марта 2026 11:11:52
 * Version: 1.0.220
 */

using System;

namespace UniRx.Operators
{
    internal class SynchronizedObserver<T> : IObserver<T>
    {
        readonly IObserver<T> observer;
        readonly object gate;

        public SynchronizedObserver(IObserver<T> observer, object gate)
        {
            this.observer = observer;
            this.gate = gate;
        }

        public void OnNext(T value)
        {
            lock (gate)
            {
                observer.OnNext(value);
            }
        }

        public void OnError(Exception error)
        {
            lock (gate)
            {
                observer.OnError(error);
            }
        }

        public void OnCompleted()
        {
            lock (gate)
            {
                observer.OnCompleted();
            }
        }
    }
}
