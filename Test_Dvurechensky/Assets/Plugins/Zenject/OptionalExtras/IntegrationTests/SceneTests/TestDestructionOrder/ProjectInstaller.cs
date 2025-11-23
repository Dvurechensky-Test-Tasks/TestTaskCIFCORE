/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 ноября 2025 06:50:27
 * Version: 1.0.94
 */

namespace Zenject.Tests.TestDestructionOrder
{
    public class ProjectInstaller : MonoInstaller<ProjectInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<FooDisposable3>().AsSingle();
        }
    }
}
