/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 ноября 2025 10:15:56
 * Version: 1.0.93
 */

using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;

namespace Zenject.Tests
{
    public class TestSceneContextEvents : SceneTestFixture
    {
        [UnityTest]
        public IEnumerator TestScene()
        {
            yield return LoadScene("TestSceneContextEvents");
            yield return new WaitForSeconds(2.0f);
        }
    }
}
