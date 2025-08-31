/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 августа 2025 07:38:17
 * Version: 1.0.9
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
