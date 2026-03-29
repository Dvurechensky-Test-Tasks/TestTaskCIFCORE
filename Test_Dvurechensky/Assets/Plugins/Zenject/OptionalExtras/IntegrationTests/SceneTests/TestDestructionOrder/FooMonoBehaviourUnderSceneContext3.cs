/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 марта 2026 11:11:52
 * Version: 1.0.220
 */

using UnityEngine;

namespace Zenject.Tests.TestDestructionOrder
{
    public class FooMonoBehaviourUnderSceneContext3 : MonoBehaviour
    {
        public void OnDestroy()
        {
            Debug.Log("Destroyed FooMonoBehaviourUnderSceneContext3");
        }
    }
}
