/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 августа 2025 07:38:17
 * Version: 1.0.9
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
