/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 декабря 2025 06:50:27
 * Version: 1.0.113
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

