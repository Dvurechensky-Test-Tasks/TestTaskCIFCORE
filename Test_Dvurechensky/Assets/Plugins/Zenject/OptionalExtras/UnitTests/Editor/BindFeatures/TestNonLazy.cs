/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 октября 2025 17:05:47
 * Version: 1.0.70
 */

using NUnit.Framework;
using Assert = ModestTree.Assert;

namespace Zenject.Tests.Bindings
{
    [TestFixture]
    public class TestNonLazy : ZenjectUnitTestFixture
    {
        [Test]
        public void Test1()
        {
            Container.Bind<Foo>().AsSingle().NonLazy();

            Assert.Throws(() => Container.ResolveRoots());
        }

        [Test]
        public void Test2()
        {
            Container.Bind<Foo>().AsSingle();

            Container.ResolveRoots();
        }

        [Test]
        public void Test3()
        {
            Container.Bind<Foo>().AsSingle().NonLazy();
            Container.Bind<Bar>().AsSingle();

            Container.ResolveRoots();
        }

        public class Foo
        {
            public Foo(Bar bar)
            {
            }
        }

        public class Bar
        {
        }
    }
}
