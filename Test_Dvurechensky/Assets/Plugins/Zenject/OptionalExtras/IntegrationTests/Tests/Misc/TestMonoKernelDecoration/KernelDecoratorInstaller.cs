/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 ноября 2025 06:50:27
 * Version: 1.0.98
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