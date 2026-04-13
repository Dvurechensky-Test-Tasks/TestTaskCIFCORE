/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 апреля 2026 12:57:35
 * Version: 1.0.235
 */

using NUnit.Framework;
using Assert = ModestTree.Assert;

namespace Zenject.Tests.Bindings
{
    [TestFixture]
    public class TestFactoryFromGetter0 : ZenjectUnitTestFixture
    {
        [Test]
        public void TestSelf()
        {
            Container.Bind<Foo>().AsSingle().NonLazy();
            Container.BindFactory<Bar, Bar.Factory>().FromResolveGetter<Foo>(x => x.Bar).NonLazy();

            Assert.IsNotNull(Container.Resolve<Bar.Factory>().Create());
            Assert.IsEqual(Container.Resolve<Bar.Factory>().Create(), Container.Resolve<Foo>().Bar);
        }

        class Bar
        {
            public class Factory : PlaceholderFactory<Bar>
            {
            }
        }

        class Foo
        {
            public Foo()
            {
                Bar = new Bar();
            }

            public Bar Bar
            {
                get;
                private set;
            }
        }
    }
}

