/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 августа 2025 07:05:58
 * Version: 1.0.6
 */

using NUnit.Framework;
using Assert = ModestTree.Assert;

namespace Zenject.Tests.Bindings
{
    [TestFixture]
    public class TestNonGeneric : ZenjectUnitTestFixture
    {
        [Test]
        public void Test1()
        {
            Assert.Throws(() =>
                Container.Bind(typeof(IFoo), typeof(IBar)).To(typeof(Foo)).AsCached());
        }

        [Test]
        public void Test2()
        {
            Assert.Throws(() =>
                Container.Bind<IFoo>().To(typeof(Bar)).AsCached());
        }

        [Test]
        public void Test3()
        {
            Assert.Throws(() =>
                Container.Bind(typeof(IFoo)).To(typeof(Bar), typeof(Foo)).AsCached());
        }

        [Test]
        public void Test4()
        {
            // This case is more lenient and just ignores invalid bindings
            Container.Bind(typeof(IFoo), typeof(IBar)).To(typeof(Foo), typeof(Bar)).AsCached();

            Assert.IsNotNull(Container.Resolve<IFoo>());
            Assert.IsNotNull(Container.Resolve<IBar>());
        }

        public interface IBar
        {
        }

        public interface IFoo
        {
        }

        public class Bar : IBar
        {
        }

        public class Foo : IFoo
        {
        }
    }
}

