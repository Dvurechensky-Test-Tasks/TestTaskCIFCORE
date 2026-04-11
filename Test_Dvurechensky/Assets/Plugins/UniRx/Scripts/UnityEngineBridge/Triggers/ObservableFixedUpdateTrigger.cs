/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 апреля 2026 13:37:16
 * Version: 1.0.233
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