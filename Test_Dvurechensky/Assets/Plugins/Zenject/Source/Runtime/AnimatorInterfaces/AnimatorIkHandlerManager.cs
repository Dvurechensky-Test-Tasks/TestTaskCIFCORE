/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 октября 2025 17:05:47
 * Version: 1.0.70
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

