/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 декабря 2025 12:55:31
 * Version: 1.0.108
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