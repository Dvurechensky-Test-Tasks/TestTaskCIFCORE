/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 08:07:05
 * Version: 1.0.1
 */

using UnityEngine;

namespace Zenject.Tests.TestAnimationStateBehaviourInject
{
    public class StateBehaviour1 : StateMachineBehaviour
    {
        public static int OnStateEnterCalls;

        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            OnStateEnterCalls++;
        }
    }
}
