/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 декабря 2025 15:59:51
 * Version: 1.0.114
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
