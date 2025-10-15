/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 октября 2025 10:47:49
 * Version: 1.0.54
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
