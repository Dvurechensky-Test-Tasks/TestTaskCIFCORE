/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 августа 2025 08:33:25
 * Version: 1.0.8
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