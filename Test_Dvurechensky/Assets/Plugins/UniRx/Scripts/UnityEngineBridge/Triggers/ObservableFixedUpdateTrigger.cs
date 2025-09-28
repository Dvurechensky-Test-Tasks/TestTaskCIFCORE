/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 сентября 2025 21:12:51
 * Version: 1.0.37
 */

using System; // require keep for Windows Universal App
using UnityEngine;

namespace UniRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableFixedUpdateTrigger : ObservableTriggerBase
    {
        Subject<Unit> fixedUpdate;

        /// <summary>This function is called every fixed framerate frame, if the MonoBehaviour is enabled.</summary>
        void FixedUpdate()
        {
            if (fixedUpdate != null) fixedUpdate.OnNext(Unit.Default);
        }

        /// <summary>This function is called every fixed framerate frame, if the MonoBehaviour is enabled.</summary>
        public IObservable<Unit> FixedUpdateAsObservable()
        {
            return fixedUpdate ?? (fixedUpdate = new Subject<Unit>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (fixedUpdate != null)
            {
                fixedUpdate.OnCompleted();
            }
        }
    }
}