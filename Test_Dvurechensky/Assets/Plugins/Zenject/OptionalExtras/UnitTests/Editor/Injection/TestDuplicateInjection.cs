/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 октября 2025 12:22:53
 * Version: 1.0.66
 */

using NUnit.Framework;
using Assert = ModestTree.Assert;

namespace Zenject.Tests.Injection
{
    [TestFixture]
    public class TestDuplicateInjection : ZenjectUnitTestFixture
    {
        class Test0
        {
        }

        class Test1
        {
            public Test1(Test0 test1)
            {
            }
        }

        [Test]
        public void TestCaseDuplicateInjection()
        {
            Container.Bind<Test0>().AsCached();
            Container.Bind<Test0>().AsCached();

            Container.Bind<Test1>().AsSingle();

            Assert.Throws(
                delegate { Container.Resolve<Test1>(); });
        }
    }
}


