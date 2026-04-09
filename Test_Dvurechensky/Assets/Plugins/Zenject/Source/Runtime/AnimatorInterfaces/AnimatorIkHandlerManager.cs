/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 апреля 2026 10:55:50
 * Version: 1.0.231
 */

using System.Collections.Generic;
using UnityEngine;

namespace Zenject
{
    public class AnimatorIkHandlerManager : MonoBehaviour
    {
        List<IAnimatorIkHandler> _handlers;

        [Inject]
        public void Construct(
            // Use local to avoid inheriting handlers from a parent context
            [Inject(Source = InjectSources.Local)]
            List<IAnimatorIkHandler> handlers)
        {
            _handlers = handlers;
        }

        public void OnAnimatorIk()
        {
            foreach (var handler in _handlers)
            {
                handler.OnAnimatorIk();
            }
        }
    }
}

