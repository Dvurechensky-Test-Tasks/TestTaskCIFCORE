/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 марта 2026 06:50:27
 * Version: 1.0.194
 */

using NUnit.Framework;
using Assert = ModestTree.Assert;

namespace Zenject.Tests.BindFeatures
{
    [TestFixture]
    public class TestRebind : ZenjectUnitTestFixture
    {
        interface ITest
        {
        }

        class Test2 : ITest
        {
        }

        class Test3 : ITest
        {
        }

        [Test]
        public void Run()
        {
            Container.Bind<ITest>().To<Test2>().AsSingle();

            Assert.That(Container.Resolve<ITest>() is Test2);

            Container.Rebind<ITest>().To<Test3>().AsSingle();

            Assert.That(Container.Resolve<ITest>() is Test3);
        }
    }
}
