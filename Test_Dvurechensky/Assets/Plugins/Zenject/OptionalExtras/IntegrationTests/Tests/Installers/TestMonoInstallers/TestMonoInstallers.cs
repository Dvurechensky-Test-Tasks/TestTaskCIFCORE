/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 сентября 2025 11:04:53
 * Version: 1.0.10
 */


using System.Collections;
using ModestTree;
using UnityEngine.TestTools;
using Zenject.Tests.Installers.MonoInstallers;

namespace Zenject.Tests.Installers
{
    public class TestMonoInstallers : ZenjectIntegrationTestFixture
    {
        [UnityTest]
        public IEnumerator TestBadResourcePath()
        {
            PreInstall();
            Assert.Throws(() => FooInstaller.InstallFromResource("TestMonoInstallers/SDFSDFSDF", Container));
            PostInstall();
            yield break;
        }

        [UnityTest]
        public IEnumerator TestZeroArgs()
        {
            PreInstall();
            FooInstaller.InstallFromResource("TestMonoInstallers/FooInstaller", Container);

            PostInstall();

            FixtureUtil.AssertResolveCount<Foo>(Container, 1);
            yield break;
        }

        [UnityTest]
        public IEnumerator TestOneArg()
        {
            PreInstall();
            BarInstaller.InstallFromResource("TestMonoInstallers/BarInstaller", Container, "blurg");

            PostInstall();

            Assert.IsEqual(Container.Resolve<string>(), "blurg");
            yield break;
        }

        [UnityTest]
        public IEnumerator TestThreeArgs()
        {
            PreInstall();
            QuxInstaller.InstallFromResource("TestMonoInstallers/QuxInstaller", Container, "blurg", 2.0f, 1);

            PostInstall();

            Assert.IsEqual(Container.Resolve<string>(), "blurg");
            yield break;
        }
    }
}

