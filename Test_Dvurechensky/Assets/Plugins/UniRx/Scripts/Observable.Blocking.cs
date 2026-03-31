/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 марта 2026 10:51:37
 * Version: 1.0.222
 */

using System;

namespace UniRx
{
    public static partial class Observable
    {
        public static T Wait<T>(this IObservable<T> source)
        {
            return new UniRx.Operators.Wait<T>(source, InfiniteTimeSpan).Run();
        }

        public static T Wait<T>(this IObservable<T> source, TimeSpan timeout)
        {
            return new UniRx.Operators.Wait<T>(source, timeout).Run();
        }
    }
}
