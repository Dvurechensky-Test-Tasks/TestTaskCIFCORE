/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 апреля 2026 14:25:30
 * Version: 1.0.230
 */

namespace Zenject.Tests.Installers.Installers
{
    public class Foo
    {
    }

    public class FooInstaller : Installer<FooInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<Foo>().AsSingle().NonLazy();
        }
    }
}
