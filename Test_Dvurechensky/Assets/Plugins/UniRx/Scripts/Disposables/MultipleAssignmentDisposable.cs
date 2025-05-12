/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 08:07:05
 * Version: 1.0.1
 */

using System;
using System.Collections;

namespace UniRx
{
    public sealed class MultipleAssignmentDisposable : IDisposable, ICancelable
    {
        static readonly BooleanDisposable True = new BooleanDisposable(true);

        object gate = new object();
        IDisposable current;

        public bool IsDisposed
        {
            get
            {
                lock (gate)
                {
                    return current == True;
                }
            }
        }

        public IDisposable Disposable
        {
            get
            {
                lock (gate)
                {
                    return (current == True)
                        ? UniRx.Disposable.Empty
                        : current;
                }
            }
            set
            {
                var shouldDispose = false;
                lock (gate)
                {
                    shouldDispose = (current == True);
                    if (!shouldDispose)
                    {
                        current = value;
                    }
                }
                if (shouldDispose && value != null)
                {
                    value.Dispose();
                }
            }
        }

        public void Dispose()
        {
            IDisposable old = null;

            lock (gate)
            {
                if (current != True)
                {
                    old = current;
                    current = True;
                }
            }

            if (old != null) old.Dispose();
        }
    }
}