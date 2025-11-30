/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 ноября 2025 14:36:10
 * Version: 1.0.101
 */

// for uGUI(from 4.6)
#if !(UNITY_4_0 || UNITY_4_1 || UNITY_4_2 || UNITY_4_3 || UNITY_4_4 || UNITY_4_5)

using System; // require keep for Windows Universal App
using UnityEngine;
using UnityEngine.EventSystems;

namespace UniRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableDropTrigger : ObservableTriggerBase, IEventSystemHandler, IDropHandler
    {
        Subject<PointerEventData> onDrop;

        void IDropHandler.OnDrop(PointerEventData eventData)
        {
            if (onDrop != null) onDrop.OnNext(eventData);
        }

        public IObservable<PointerEventData> OnDropAsObservable()
        {
            return onDrop ?? (onDrop = new Subject<PointerEventData>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onDrop != null)
            {
                onDrop.OnCompleted();
            }
        }
    }
}


#endif