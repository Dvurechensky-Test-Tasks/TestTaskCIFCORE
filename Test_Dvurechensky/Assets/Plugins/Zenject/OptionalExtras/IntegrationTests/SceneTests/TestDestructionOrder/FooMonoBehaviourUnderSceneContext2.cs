/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 февраля 2026 10:31:34
 * Version: 1.0.175
 */

using UnityEngine;

namespace Zenject.Tests.TestDestructionOrder
{
    public class FooMonoBehaviourUnderSceneContext2 : MonoBehaviour
    {
        public void OnDestroy()
        {
            Debug.Log("Destroyed FooMonoBehaviourUnderSceneContext2");
        }
    }
}
