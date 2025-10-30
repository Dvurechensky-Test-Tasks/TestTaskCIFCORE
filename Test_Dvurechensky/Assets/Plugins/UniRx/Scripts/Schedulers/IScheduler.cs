/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 октября 2025 17:05:47
 * Version: 1.0.70
 */

using System;

namespace UniRx
{
    public interface IScheduler
    {
        DateTimeOffset Now { get; }

        // Interface is changed from official Rx for avoid iOS AOT problem (state is dangerous).

        IDisposable Schedule(Action action);

        IDisposable Schedule(TimeSpan dueTime, Action action);
    }

    public interface ISchedulerPeriodic
    {
        IDisposable SchedulePeriodic(TimeSpan period, Action action);
    }

    public interface ISchedulerLongRunning
    {
        IDisposable ScheduleLongRunning(Action<ICancelable> action);
    }

    public interface ISchedulerQueueing
    {
        void ScheduleQueueing<T>(ICancelable cancel, T state, Action<T> action);
    }
}