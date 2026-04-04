/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 апреля 2026 12:57:33
 * Version: 1.0.226
 */


#if !(UNITY_WSA && ENABLE_DOTNET)

using NUnit.Framework;
using Assert = ModestTree.Assert;

namespace Zenject.Tests.Convention.Names
{
    [TestFixture]
    public class TestConventionNames : ZenjectUnitTestFixture
    {
        [Test]
        public void TestWithSuffix()
        {
            Container.Bind<IController>()
                .To(x => x.AllNonAbstractClasses().InNamespace("Zenject.Tests.Convention.Names").WithSuffix("Controller")).AsTransient();

            Assert.That(Container.Resolve<IController>() is FooController);
        }

        [Test]
        public void TestWithPrefix()
        {
            Container.Bind<IController>()
                .To(x => x.AllTypes().InNamespace("Zenject.Tests.Convention.Names").WithPrefix("Controller")).AsTransient();

            Assert.That(Container.Resolve<IController>() is ControllerBar);
        }

        [Test]
        public void TestMatchingRegex()
        {
            Container.Bind<IController>()
                .To(x => x.AllNonAbstractClasses().InNamespace("Zenject.Tests.Convention.Names").MatchingRegex("Controller$")).AsTransient();

            Assert.That(Container.Resolve<IController>() is FooController);
        }

        interface IController
        {
        }

        class FooController : IController
        {
        }

        class ControllerBar : IController
        {
        }

        class QuxControllerAsdf : IController
        {
        }

        class IgnoredFooController
        {
        }

        class ControllerBarIgnored
        {
        }
    }
}

#endif
