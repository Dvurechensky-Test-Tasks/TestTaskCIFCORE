/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 августа 2025 07:05:58
 * Version: 1.0.6
 */

using UnityEngine;
using Zenject;

namespace Zenject.Tests.TestAnimationStateBehaviourInject
{
    public class KernelDecoratorInstaller : Installer<KernelDecoratorInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<DecoratableMonoKernel>().AsCached();
            Container.Decorate<IDecoratableMonoKernel>().With<DelayedInitializeKernel>();
        }
    }
}