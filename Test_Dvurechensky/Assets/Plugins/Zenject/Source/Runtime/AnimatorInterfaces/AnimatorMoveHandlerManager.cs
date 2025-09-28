/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 сентября 2025 21:12:51
 * Version: 1.0.37
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

