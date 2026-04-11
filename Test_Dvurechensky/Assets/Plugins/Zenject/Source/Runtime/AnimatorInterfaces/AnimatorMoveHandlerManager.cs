/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 апреля 2026 13:37:16
 * Version: 1.0.233
 */

using System.Collections.Generic;
using UnityEngine;

namespace Zenject
{
    public class AnimatorMoveHandlerManager : MonoBehaviour
    {
        List<IAnimatorMoveHandler> _handlers;

        [Inject]
        public void Construct(
            // Use local to avoid inheriting handlers from a parent context
            [Inject(Source = InjectSources.Local)]
            List<IAnimatorMoveHandler> handlers)
        {
            _handlers = handlers;
        }

        public void OnAnimatorMove()
        {
            foreach (var handler in _handlers)
            {
                handler.OnAnimatorMove();
            }
        }
    }
}

