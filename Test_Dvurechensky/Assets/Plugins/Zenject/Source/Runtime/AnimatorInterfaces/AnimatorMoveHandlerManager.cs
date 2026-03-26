/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 марта 2026 10:03:13
 * Version: 1.0.217
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

