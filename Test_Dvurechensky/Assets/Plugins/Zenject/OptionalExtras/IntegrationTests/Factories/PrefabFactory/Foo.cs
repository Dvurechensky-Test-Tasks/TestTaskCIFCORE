/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 августа 2025 07:05:58
 * Version: 1.0.6
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
