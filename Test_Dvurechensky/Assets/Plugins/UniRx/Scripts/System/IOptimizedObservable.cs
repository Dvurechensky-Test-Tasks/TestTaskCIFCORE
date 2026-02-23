/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 февраля 2026 14:21:11
 * Version: 1.0.186
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