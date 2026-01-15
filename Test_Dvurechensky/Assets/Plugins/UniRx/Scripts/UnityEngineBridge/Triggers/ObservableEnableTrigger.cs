/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 января 2026 17:28:28
 * Version: 1.0.147
 */

using System; // require keep for Windows Universal App
using UnityEngine;

namespace UniRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableEnableTrigger : ObservableTriggerBase
    {
        Subject<Unit> onEnable;

        /// <summary>This function is called when the object becomes enabled and active.</summary>
        void OnEnable()
        {
            if (onEnable != null) onEnable.OnNext(Unit.Default);
        }

        /// <summary>This function is called when the object becomes enabled and active.</summary>
        public IObservable<Unit> OnEnableAsObservable()
        {
            return onEnable ?? (onEnable = new Subject<Unit>());
        }

        Subject<Unit> onDisable;

        /// <summary>This function is called when the behaviour becomes disabled () or inactive.</summary>
        void OnDisable()
        {
            if (onDisable != null) onDisable.OnNext(Unit.Default);
        }

        /// <summary>This function is called when the behaviour becomes disabled () or inactive.</summary>
        public IObservable<Unit> OnDisableAsObservable()
        {
            return onDisable ?? (onDisable = new Subject<Unit>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onEnable != null)
            {
                onEnable.OnCompleted();
            }
            if (onDisable != null)
            {
                onDisable.OnCompleted();
            }
        }
    }
}