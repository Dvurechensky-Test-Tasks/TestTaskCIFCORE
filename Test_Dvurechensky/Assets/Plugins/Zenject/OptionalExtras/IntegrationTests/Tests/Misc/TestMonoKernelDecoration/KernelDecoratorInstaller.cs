/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 ноября 2025 17:21:45
 * Version: 1.0.73
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