/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 декабря 2025 15:50:16
 * Version: 1.0.128
 */

#if !(UNITY_IPHONE || UNITY_ANDROID || UNITY_METRO)

using UnityEngine;
using UniRx.Triggers; // for enable gameObject.EventAsObservbale()

namespace UniRx.Examples
{
    public class Sample03_GameObjectAsObservable : MonoBehaviour
    {
        void Start()
        {
            // All events can subscribe by ***AsObservable if enables UniRx.Triggers
            this.OnMouseDownAsObservable()
                .SelectMany(_ => this.gameObject.UpdateAsObservable())
                .TakeUntil(this.gameObject.OnMouseUpAsObservable())
                .Select(_ => Input.mousePosition)
                .RepeatUntilDestroy(this)
                .Subscribe(x => Debug.Log(x), ()=> Debug.Log("!!!" + "complete"));
        }
    }
}

#endif