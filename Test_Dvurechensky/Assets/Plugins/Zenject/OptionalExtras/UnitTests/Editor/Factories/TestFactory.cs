/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 апреля 2026 12:46:40
 * Version: 1.0.228
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


