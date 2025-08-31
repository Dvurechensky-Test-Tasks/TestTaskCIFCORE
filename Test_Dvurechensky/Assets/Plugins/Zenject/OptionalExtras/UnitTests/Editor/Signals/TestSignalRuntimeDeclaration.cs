/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 августа 2025 07:38:17
 * Version: 1.0.9
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
