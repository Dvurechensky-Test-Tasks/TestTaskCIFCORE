/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 19 ноября 2025 08:14:27
 * Version: 1.0.90
 */

namespace Zenject.Tests.Installers.MonoInstallers
{
    public class Foo
    {
    }

    public class FooInstaller : MonoInstaller<FooInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<Foo>().AsSingle().NonLazy();
        }
    }
}
