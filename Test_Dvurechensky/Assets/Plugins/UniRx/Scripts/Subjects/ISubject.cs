/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 февраля 2026 07:40:37
 * Version: 1.0.168
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace UniRx
{
    public interface ISubject<TSource, TResult> : IObserver<TSource>, IObservable<TResult>
    {
    }

    public interface ISubject<T> : ISubject<T, T>, IObserver<T>, IObservable<T>
    {
    }
}