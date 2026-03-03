/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 марта 2026 06:50:27
 * Version: 1.0.194
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
