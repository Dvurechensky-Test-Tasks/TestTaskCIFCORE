/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 сентября 2025 08:07:37
 * Version: 1.0.13
 */

using System; // require keep for Windows Universal App
using UnityEngine;

namespace UniRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableVisibleTrigger : ObservableTriggerBase
    {
        Subject<Unit> onBecameInvisible;

        /// <summary>OnBecameInvisible is called when the renderer is no longer visible by any camera.</summary>
        void OnBecameInvisible()
        {
            if (onBecameInvisible != null) onBecameInvisible.OnNext(Unit.Default);
        }

        /// <summary>OnBecameInvisible is called when the renderer is no longer visible by any camera.</summary>
        public IObservable<Unit> OnBecameInvisibleAsObservable()
        {
            return onBecameInvisible ?? (onBecameInvisible = new Subject<Unit>());
        }

        Subject<Unit> onBecameVisible;

        /// <summary>OnBecameVisible is called when the renderer became visible by any camera.</summary>
        void OnBecameVisible()
        {
            if (onBecameVisible != null) onBecameVisible.OnNext(Unit.Default);
        }

        /// <summary>OnBecameVisible is called when the renderer became visible by any camera.</summary>
        public IObservable<Unit> OnBecameVisibleAsObservable()
        {
            return onBecameVisible ?? (onBecameVisible = new Subject<Unit>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onBecameInvisible != null)
            {
                onBecameInvisible.OnCompleted();
            }
            if (onBecameVisible != null)
            {
                onBecameVisible.OnCompleted();
            }
        }
    }
}