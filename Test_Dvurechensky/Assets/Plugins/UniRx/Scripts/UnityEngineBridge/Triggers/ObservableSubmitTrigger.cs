/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 08:07:05
 * Version: 1.0.1
 */

// for uGUI(from 4.6)
#if !(UNITY_4_0 || UNITY_4_1 || UNITY_4_2 || UNITY_4_3 || UNITY_4_4 || UNITY_4_5)

using System; // require keep for Windows Universal App
using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableSubmitTrigger : ObservableTriggerBase, IEventSystemHandler, ISubmitHandler
    {
        Subject<BaseEventData> onSubmit;

        void ISubmitHandler.OnSubmit(BaseEventData eventData)
        {
            if (onSubmit != null) onSubmit.OnNext(eventData);
        }

        public IObservable<BaseEventData> OnSubmitAsObservable()
        {
            return onSubmit ?? (onSubmit = new Subject<BaseEventData>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onSubmit != null)
            {
                onSubmit.OnCompleted();
            }
        }
    }
}


#endif