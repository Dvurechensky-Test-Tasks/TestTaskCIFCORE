/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 ноября 2025 09:29:31
 * Version: 1.0.92
 */

using NUnit.Framework;

namespace Zenject
{
    // Inherit from this and mark you class with [TestFixture] attribute to do some unit tests
    // For anything more complicated than this, such as tests involving interaction between
    // several classes, or if you want to use interfaces such as IInitializable or IDisposable,
    // then I recommend using ZenjectIntegrationTestFixture instead
    // See documentation for details
    public abstract class ZenjectUnitTestFixture
    {
        DiContainer _container;

        protected DiContainer Container
        {
            get { return _container; }
        }

        [SetUp]
        public virtual void Setup()
        {
            _container = new DiContainer(StaticContext.Container);
        }

        [TearDown]
        public virtual void Teardown()
        {
            StaticContext.Clear();
        }
    }
}
