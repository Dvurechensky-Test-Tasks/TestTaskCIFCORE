/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 апреля 2026 12:23:01
 * Version: 1.0.236
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

