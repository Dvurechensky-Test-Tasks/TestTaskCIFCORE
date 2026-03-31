/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 марта 2026 10:51:37
 * Version: 1.0.222
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
