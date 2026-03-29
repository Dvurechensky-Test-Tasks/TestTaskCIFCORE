/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 марта 2026 11:11:52
 * Version: 1.0.220
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
