/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 декабря 2025 13:30:14
 * Version: 1.0.127
 */

using ModestTree;

namespace Zenject.Tests.DecoratorTests
{
    public class Bar
    {
    }

    public class Foo
    {
        public Foo(Bar bar)
        {
            Log.Trace("Created Foo");
        }
    }

    public class Scene2Installer : MonoInstaller<Scene2Installer>
    {
        public override void InstallBindings()
        {
            Container.Bind<Foo>().AsSingle().NonLazy();
        }
    }
}
