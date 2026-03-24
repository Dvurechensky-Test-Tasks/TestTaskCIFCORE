/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 марта 2026 08:52:35
 * Version: 1.0.215
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
