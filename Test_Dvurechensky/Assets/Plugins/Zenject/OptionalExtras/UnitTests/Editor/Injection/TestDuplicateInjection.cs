/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 февраля 2026 11:48:56
 * Version: 1.0.176
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


