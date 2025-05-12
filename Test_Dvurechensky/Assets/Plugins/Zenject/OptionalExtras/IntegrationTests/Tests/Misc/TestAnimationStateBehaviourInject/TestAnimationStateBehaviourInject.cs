/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 08:07:05
 * Version: 1.0.1
 */


using System.Collections;
using ModestTree;
using UnityEngine.TestTools;

namespace Zenject.Tests.TestAnimationStateBehaviourInject
{
    public class TestAnimationStateBehaviourInject : ZenjectIntegrationTestFixture
    {
        const string ResourcePrefix = "TestAnimationStateBehaviourInject/";

        [UnityTest]
        public IEnumerator Test1()
        {
            PreInstall();
            var prefab = FixtureUtil.GetPrefab(ResourcePrefix + "Foo");

            StateBehaviour1.OnStateEnterCalls = 0;

            Container.InstantiatePrefab(prefab);
            Container.BindInterfacesAndSelfTo<Foo>().AsSingle();
            PostInstall();

            yield return null;

            Assert.IsEqual(StateBehaviour1.OnStateEnterCalls, 1);
        }

        public class Foo : IInitializable
        {
            public bool HasInitialized
            {
                get; private set;
            }

            public void Initialize()
            {
                HasInitialized = true;
            }
        }
    }
}

