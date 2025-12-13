/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 декабря 2025 15:59:51
 * Version: 1.0.114
 */

using System; // require keep for Windows Universal App
using UnityEngine;

namespace UniRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableLateUpdateTrigger : ObservableTriggerBase
    {
        Subject<Unit> lateUpdate;

        /// <summary>LateUpdate is called every frame, if the Behaviour is enabled.</summary>
        void LateUpdate()
        {
            if (lateUpdate != null) lateUpdate.OnNext(Unit.Default);
        }

        /// <summary>LateUpdate is called every frame, if the Behaviour is enabled.</summary>
        public IObservable<Unit> LateUpdateAsObservable()
        {
            return lateUpdate ?? (lateUpdate = new Subject<Unit>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (lateUpdate != null)
            {
                lateUpdate.OnCompleted();
            }
        }
    }
}