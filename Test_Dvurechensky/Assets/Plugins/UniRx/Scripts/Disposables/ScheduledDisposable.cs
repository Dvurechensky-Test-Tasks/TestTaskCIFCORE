/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 сентября 2025 07:55:35
 * Version: 1.0.12
 */

using System;
using System.Threading;

namespace UniRx
{
    public sealed class ScheduledDisposable : ICancelable
    {
        private readonly IScheduler scheduler;
        private volatile IDisposable disposable;
        private int isDisposed = 0;

        public ScheduledDisposable(IScheduler scheduler, IDisposable disposable)
        {
            this.scheduler = scheduler;
            this.disposable = disposable;
        }

        public IScheduler Scheduler
        {
            get { return scheduler; }
        }

        public IDisposable Disposable
        {
            get { return disposable; }
        }

        public bool IsDisposed
        {
            get { return isDisposed != 0; }
        }

        public void Dispose()
        {
            Scheduler.Schedule(DisposeInner);
        }

        private void DisposeInner()
        {
            if (Interlocked.Increment(ref isDisposed) == 1)
            {
                disposable.Dispose();
            }
        }
    }
}
