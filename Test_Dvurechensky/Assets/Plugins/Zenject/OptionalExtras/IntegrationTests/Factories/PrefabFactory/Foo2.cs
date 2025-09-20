/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 сентября 2025 14:13:53
 * Version: 1.0.29
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

