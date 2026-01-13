/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 января 2026 13:15:15
 * Version: 1.0.145
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
