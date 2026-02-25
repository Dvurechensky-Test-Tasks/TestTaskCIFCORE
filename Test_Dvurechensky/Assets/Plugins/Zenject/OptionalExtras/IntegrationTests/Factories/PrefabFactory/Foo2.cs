/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 февраля 2026 13:59:57
 * Version: 1.0.188
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

