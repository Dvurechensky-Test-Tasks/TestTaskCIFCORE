/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 08:07:05
 * Version: 1.0.1
 */

using NUnit.Framework;
using Assert = ModestTree.Assert;

namespace Zenject.Tests.Conditions
{
    [TestFixture]
    public class TestIdentifiers : ZenjectUnitTestFixture
    {
        class Test0
        {
        }

        [Test]
        public void TestBasic()
        {
            Container.Bind<Test0>().WithId("foo").AsTransient().NonLazy();

            Assert.Throws(
                delegate { Container.Resolve<Test0>(); });

            Container.ResolveId<Test0>("foo");
        }

        [Test]
        public void TestBasic2()
        {
            Container.Bind<Test0>().WithId("foo").AsSingle().NonLazy();

            Assert.Throws(
                delegate { Container.Resolve<Test0>(); });

            Container.ResolveId<Test0>("foo");
        }

        [Test]
        public void TestBasic3()
        {
            Container.Bind<Test0>().WithId("foo").FromMethod(ctx => new Test0()).NonLazy();

            Assert.Throws(
                delegate { Container.Resolve<Test0>(); });

            Container.ResolveId<Test0>("foo");
        }

        [Test]
        public void TestBasic4()
        {
            Container.Bind<Test0>().WithId("foo").AsTransient().NonLazy();
            Container.Bind<Test0>().WithId("foo").AsTransient().NonLazy();

            Assert.Throws(
                delegate { Container.Resolve<Test0>(); });

            Assert.Throws(
                delegate { Container.ResolveId<Test0>("foo"); });

            Assert.IsEqual(Container.ResolveIdAll<Test0>("foo").Count, 2);
        }

        [Test]
        public void TestFromMethodUntyped()
        {
            Container.Bind(typeof(Test0)).FromMethod(ctx => new Test0()).NonLazy();

            Container.Resolve<Test0>();
        }
    }
}
