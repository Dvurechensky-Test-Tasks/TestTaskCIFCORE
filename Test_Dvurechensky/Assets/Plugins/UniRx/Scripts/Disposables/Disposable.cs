/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 сентября 2025 07:55:35
 * Version: 1.0.12
 */

using System;
using System.Collections;

namespace UniRx
{
    public static class Disposable
    {
        public static readonly IDisposable Empty = EmptyDisposable.Singleton;

        public static IDisposable Create(Action disposeAction)
        {
            return new AnonymousDisposable(disposeAction);
        }

        public static IDisposable CreateWithState<TState>(TState state, Action<TState> disposeAction)
        {
            return new AnonymousDisposable<TState>(state, disposeAction);
        }

        class EmptyDisposable : IDisposable
        {
            public static EmptyDisposable Singleton = new EmptyDisposable();

            private EmptyDisposable()
            {

            }

            public void Dispose()
            {
            }
        }

        class AnonymousDisposable : IDisposable
        {
            bool isDisposed = false;
            readonly Action dispose;

            public AnonymousDisposable(Action dispose)
            {
                this.dispose = dispose;
            }

            public void Dispose()
            {
                if (!isDisposed)
                {
                    isDisposed = true;
                    dispose();
                }
            }
        }

        class AnonymousDisposable<T> : IDisposable
        {
            bool isDisposed = false;
            readonly T state;
            readonly Action<T> dispose;

            public AnonymousDisposable(T state, Action<T> dispose)
            {
                this.state = state;
                this.dispose = dispose;
            }

            public void Dispose()
            {
                if (!isDisposed)
                {
                    isDisposed = true;
                    dispose(state);
                }
            }
        }
    }
}