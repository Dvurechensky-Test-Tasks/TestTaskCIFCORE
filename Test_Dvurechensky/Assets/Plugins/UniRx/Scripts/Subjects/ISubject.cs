/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 декабря 2025 14:32:37
 * Version: 1.0.115
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