/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 марта 2026 10:03:13
 * Version: 1.0.217
 */

using NUnit.Framework;
using Assert = ModestTree.Assert;

namespace Zenject.Tests.BindFeatures
{
    [TestFixture]
    public class TestIfNotBound : ZenjectUnitTestFixture
    {
        interface IFoo
        {
        }

        public class Foo1 : IFoo
        {
        }

        public class Foo2 : IFoo
        {
        }

        [Test]
        public void Test1()
        {
            Container.Bind<IFoo>().To<Foo1>().AsSingle();
            Container.Bind<IFoo>().To<Foo2>().AsSingle();

            Assert.IsEqual(Container.ResolveAll<IFoo>().Count, 2);
        }

        [Test]
        public void Test2()
        {
            Container.Bind<IFoo>().To<Foo1>().AsSingle();
            Container.Bind<IFoo>().To<Foo2>().AsSingle().IfNotBound();

            Assert.IsEqual(Container.ResolveAll<IFoo>().Count, 1);
            Assert.IsType<Foo1>(Container.Resolve<IFoo>());
        }
    }
}

