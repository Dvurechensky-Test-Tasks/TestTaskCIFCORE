/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 19 октября 2025 13:34:20
 * Version: 1.0.58
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
