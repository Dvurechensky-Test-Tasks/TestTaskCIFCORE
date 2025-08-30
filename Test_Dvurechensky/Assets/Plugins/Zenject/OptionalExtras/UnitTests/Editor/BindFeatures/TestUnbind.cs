/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 августа 2025 08:33:25
 * Version: 1.0.8
 */

using NUnit.Framework;
using Assert = ModestTree.Assert;

namespace Zenject.Tests.BindFeatures
{
    [TestFixture]
    public class TestUnbind : ZenjectUnitTestFixture
    {
        interface ITest
        {
        }

        interface ITest2
        {
        }

        class Test2 : ITest, ITest2
        {
        }

        [Test]
        public void Run()
        {
            Container.Bind<ITest>().To<Test2>().AsSingle();

            Assert.IsNotNull(Container.Resolve<ITest>());

            Container.Unbind<ITest>();

            Assert.IsNull(Container.TryResolve<ITest>());
        }

        [Test]
        public void TestUnbindInterfaces()
        {
            Container.BindInterfacesTo<Test2>().AsSingle();

            Assert.IsNotNull(Container.Resolve<ITest>());
            Assert.IsNotNull(Container.Resolve<ITest2>());

            Container.UnbindInterfacesTo<Test2>();

            Assert.IsNull(Container.TryResolve<ITest>());
            Assert.IsNull(Container.TryResolve<ITest2>());
        }

        // Do we care about this?
        //[Test]
        public void TestUnbindAsSingle()
        {
            Container.Bind<ITest>().To<Test2>().AsSingle();

            Container.Unbind<ITest>();

            Assert.IsNull(Container.TryResolve<ITest>());

            Container.Bind<ITest>().To<Test2>().AsSingle();

            Assert.IsNotNull(Container.TryResolve<ITest>());
        }
    }
}
