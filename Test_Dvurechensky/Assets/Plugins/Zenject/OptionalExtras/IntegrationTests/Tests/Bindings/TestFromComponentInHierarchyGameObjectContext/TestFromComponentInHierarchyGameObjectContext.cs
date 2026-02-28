/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 февраля 2026 15:54:06
 * Version: 1.0.191
 */


using System.Collections;
using System.Linq;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Assert = ModestTree.Assert;

namespace Zenject.Tests.Bindings.FromComponentInHierarchyGameObjectContext
{
    public class TestFromComponentInHierarchyGameObjectContext : ZenjectIntegrationTestFixture
    {
        GameObject FooPrefab
        {
            get
            {
                return FixtureUtil.GetPrefab("TestFromComponentInHierarchyGameObjectContext/Foo");
            }
        }

        [SetUp]
        public void SetUp()
        {
            new GameObject().AddComponent<Gorp>();
            new GameObject().AddComponent<Gorp>();
        }

        [UnityTest]
        public IEnumerator TestCorrectHierarchy()
        {
            PreInstall();

            Container.Bind<Foo>().FromSubContainerResolve()
                .ByNewContextPrefab(FooPrefab).AsSingle().NonLazy();

            PostInstall();

            var foo = Container.Resolve<Foo>();

            Assert.IsNotNull(foo.Gorp);
            Assert.IsEqual(foo.gameObject.GetComponentsInChildren<Gorp>().Single(), foo.Gorp);
            yield break;
        }
    }
}

