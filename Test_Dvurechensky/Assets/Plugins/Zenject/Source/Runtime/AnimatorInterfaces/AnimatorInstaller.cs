/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 декабря 2025 14:02:32
 * Version: 1.0.112
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

