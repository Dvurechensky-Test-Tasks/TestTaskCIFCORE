/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 апреля 2026 13:37:16
 * Version: 1.0.233
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

