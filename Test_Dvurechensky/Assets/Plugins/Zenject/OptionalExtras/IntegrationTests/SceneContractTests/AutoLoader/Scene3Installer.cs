/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 марта 2026 13:10:06
 * Version: 1.0.214
 */

using ModestTree;

namespace Zenject.Tests.AutoLoadSceneTests
{
    public class Qux
    {
    }

    public class Bar
    {
        public Bar(Qux qux)
        {
        }
    }

    public class Foo
    {
        public Foo(Bar bar)
        {
            Log.Trace("Created Foo");
        }
    }

    public class Scene3Installer : MonoInstaller<Scene3Installer>
    {
        public override void InstallBindings()
        {
            Container.Bind<Foo>().AsSingle().NonLazy();
        }
    }
}
