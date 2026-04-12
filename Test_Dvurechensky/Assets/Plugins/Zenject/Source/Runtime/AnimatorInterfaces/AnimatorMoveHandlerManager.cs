/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 апреля 2026 14:13:56
 * Version: 1.0.234
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

