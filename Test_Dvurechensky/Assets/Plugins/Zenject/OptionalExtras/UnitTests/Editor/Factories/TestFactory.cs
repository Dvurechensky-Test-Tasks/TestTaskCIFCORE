/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 сентября 2025 17:13:59
 * Version: 1.0.32
 */

using NUnit.Framework;
using Assert = ModestTree.Assert;

namespace Zenject.Tests.AbstractFactory
{
    [TestFixture]
    public class TestFactory : ZenjectUnitTestFixture
    {
        [Test]
        public void TestToSelf()
        {
            Container.BindFactory<Foo, Foo.Factory>().NonLazy();

            Assert.IsNotNull(Container.Resolve<Foo.Factory>().Create());
        }

        public interface IFoo
        {
        }

        public class Foo : IFoo
        {
            public class Factory : PlaceholderFactory<Foo>
            {
            }
        }
    }
}


