/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 ноября 2025 09:06:52
 * Version: 1.0.99
 */

using NUnit.Framework;
using Assert = ModestTree.Assert;

namespace Zenject.Tests.Bindings
{
    [TestFixture]
    public class TestFactoryFromMethod0 : ZenjectUnitTestFixture
    {
        [Test]
        public void TestSelf()
        {
            var foo = new Foo();

            Container.BindFactory<Foo, Foo.Factory>().FromMethod(c => foo).NonLazy();

            Assert.IsEqual(Container.Resolve<Foo.Factory>().Create(), foo);
        }

        [Test]
        public void TestConcrete()
        {
            var foo = new Foo();

            Container.BindFactory<IFoo, IFooFactory>().FromMethod(c => foo).NonLazy();

            Assert.IsEqual(Container.Resolve<IFooFactory>().Create(), foo);
        }

        interface IFoo
        {
        }

        class IFooFactory : PlaceholderFactory<IFoo>
        {
        }

        class Foo : IFoo
        {
            public class Factory : PlaceholderFactory<Foo>
            {
            }
        }
    }
}

