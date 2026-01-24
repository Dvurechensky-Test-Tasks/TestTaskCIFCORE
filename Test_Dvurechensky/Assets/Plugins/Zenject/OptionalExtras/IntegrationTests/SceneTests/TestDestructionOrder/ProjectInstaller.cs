/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 января 2026 09:16:42
 * Version: 1.0.156
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
