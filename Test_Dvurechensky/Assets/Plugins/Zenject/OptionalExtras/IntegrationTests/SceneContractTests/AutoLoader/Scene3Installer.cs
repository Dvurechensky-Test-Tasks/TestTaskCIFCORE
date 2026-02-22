/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 февраля 2026 13:30:34
 * Version: 1.0.185
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
