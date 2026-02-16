/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 февраля 2026 12:46:49
 * Version: 1.0.179
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
