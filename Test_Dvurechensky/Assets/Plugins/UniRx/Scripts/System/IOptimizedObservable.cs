/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 декабря 2025 09:27:48
 * Version: 1.0.125
 */

using System;

namespace UniRx
{
    public interface IOptimizedObservable<T> : IObservable<T>
    {
        bool IsRequiredSubscribeOnCurrentThread();
    }

    public static class OptimizedObservableExtensions
    {
        public static bool IsRequiredSubscribeOnCurrentThread<T>(this IObservable<T> source)
        {
            var obs = source as IOptimizedObservable<T>;
            if (obs == null) return true;

            return obs.IsRequiredSubscribeOnCurrentThread();
        }

        public static bool IsRequiredSubscribeOnCurrentThread<T>(this IObservable<T> source, IScheduler scheduler)
        {
            if (scheduler == Scheduler.CurrentThread) return true;

            return IsRequiredSubscribeOnCurrentThread(source);
        }
    }
}