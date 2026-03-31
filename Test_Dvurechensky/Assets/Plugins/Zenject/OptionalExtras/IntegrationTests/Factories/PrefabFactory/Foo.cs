/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 марта 2026 10:51:37
 * Version: 1.0.222
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
