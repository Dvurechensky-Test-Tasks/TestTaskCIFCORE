/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 апреля 2026 12:30:12
 * Version: 1.0.232
 */

using UnityEngine;

namespace Zenject
{
    public class AnimatorInstaller : Installer<Animator, AnimatorInstaller>
    {
        readonly Animator _animator;

        public AnimatorInstaller(Animator animator)
        {
            _animator = animator;
        }

        public override void InstallBindings()
        {
            Container.Bind<AnimatorIkHandlerManager>().FromNewComponentOn(_animator.gameObject);
            Container.Bind<AnimatorIkHandlerManager>().FromNewComponentOn(_animator.gameObject);
        }
    }
}

