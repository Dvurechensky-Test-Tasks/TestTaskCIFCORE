/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 08:07:05
 * Version: 1.0.1
 */

using System; // require keep for Windows Universal App
using UnityEngine;

namespace UniRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableUpdateTrigger : ObservableTriggerBase
    {
        Subject<Unit> update;

        /// <summary>Update is called every frame, if the MonoBehaviour is enabled.</summary>
        void Update()
        {
            if (update != null) update.OnNext(Unit.Default);
        }

        /// <summary>Update is called every frame, if the MonoBehaviour is enabled.</summary>
        public IObservable<Unit> UpdateAsObservable()
        {
            return update ?? (update = new Subject<Unit>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (update != null)
            {
                update.OnCompleted();
            }
        }
    }
}