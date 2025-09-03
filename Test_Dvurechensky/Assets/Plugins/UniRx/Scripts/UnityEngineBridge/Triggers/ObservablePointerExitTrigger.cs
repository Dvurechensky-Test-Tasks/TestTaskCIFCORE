/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 сентября 2025 07:55:35
 * Version: 1.0.12
 */

// for uGUI(from 4.6)
#if !(UNITY_4_0 || UNITY_4_1 || UNITY_4_2 || UNITY_4_3 || UNITY_4_4 || UNITY_4_5)

using System; // require keep for Windows Universal App
using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservablePointerExitTrigger : ObservableTriggerBase, IEventSystemHandler, IPointerExitHandler
    {
        Subject<PointerEventData> onPointerExit;

        void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
        {
            if (onPointerExit != null) onPointerExit.OnNext(eventData);
        }

        public IObservable<PointerEventData> OnPointerExitAsObservable()
        {
            return onPointerExit ?? (onPointerExit = new Subject<PointerEventData>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onPointerExit != null)
            {
                onPointerExit.OnCompleted();
            }
        }
    }
}


#endif