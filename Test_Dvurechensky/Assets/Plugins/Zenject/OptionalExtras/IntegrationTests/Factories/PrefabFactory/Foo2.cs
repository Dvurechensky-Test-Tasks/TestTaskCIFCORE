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
    public class Foo2 : MonoBehaviour
    {
        [Inject]
        public string Value
        {
            get; private set;
        }

        public class Factory : PlaceholderFactory<Object, string, Foo2>
        {
        }

        public class Factory2 : PlaceholderFactory<string, string, Foo2>
        {
        }
    }
}

