/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 марта 2026 10:10:08
 * Version: 1.0.219
 */

using UnityEngine;

namespace Zenject.Tests.Factories.PrefabFactory
{
    public class Foo : MonoBehaviour
    {
        public bool WasInitialized;

        [Inject]
        public void Init()
        {
            WasInitialized = true;
        }

        public class Factory : PlaceholderFactory<Object, Foo>
        {
        }

        public class Factory2 : PlaceholderFactory<string, Foo>
        {
        }
    }
}
