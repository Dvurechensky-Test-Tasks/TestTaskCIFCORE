/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 августа 2025 08:33:25
 * Version: 1.0.8
 */

using UnityEngine;
using UniRx.Triggers; // Triggers Namepsace
using System;

namespace UniRx.Examples
{
    public class Sample02_ObservableTriggers : MonoBehaviour
    {
        void Start()
        {
            // Get the plain object
            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

            // Add ObservableXxxTrigger for handle MonoBehaviour's event as Observable
            cube.AddComponent<ObservableUpdateTrigger>()
                .UpdateAsObservable()
                .SampleFrame(30)
                .Subscribe(x => Debug.Log("cube"), () => Debug.Log("destroy"));

            // destroy after 3 second:)
            GameObject.Destroy(cube, 3f);
        }
    }
}