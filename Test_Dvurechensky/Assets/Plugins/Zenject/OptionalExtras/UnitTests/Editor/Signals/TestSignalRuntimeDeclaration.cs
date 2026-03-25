/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 марта 2026 10:12:55
 * Version: 1.0.216
 */

using System;
using NUnit.Framework;
using Assert = ModestTree.Assert;

namespace Zenject.Tests.Signals
{
    public class FooSignal
    {
    }

    [TestFixture]
    public class TestSignalRuntimeDeclaration : ZenjectUnitTestFixture
    {
        [SetUp]
        public void InstallCommon()
        {
            SignalBusInstaller.Install(Container);
            Container.Inject(this);
        }

        [Inject]
        SignalBus _signalBus = null;

        [Test]
        public void TestMissingDeclaration()
        {
            Assert.Throws(() => _signalBus.Fire(new FooSignal()));
        }

        [Test]
        public void TestFireSuccess()
        {
            _signalBus.DeclareSignal<FooSignal>();
            _signalBus.Fire(new FooSignal());
        }

        [Test]
        public void TestIdentifierMissing()
        {
            _signalBus.DeclareSignal<FooSignal>();
            Assert.Throws(() => _signalBus.FireId("asdf", new FooSignal()));
        }

        [Test]
        public void TestIdentifier()
        {
            _signalBus.DeclareSignal<FooSignal>("asdf");
            _signalBus.FireId("asdf", new FooSignal());
        }
    }
}
