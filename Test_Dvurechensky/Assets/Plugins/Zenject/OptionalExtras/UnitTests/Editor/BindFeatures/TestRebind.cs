/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 сентября 2025 11:44:34
 * Version: 1.0.15
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
