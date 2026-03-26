/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 марта 2026 10:03:13
 * Version: 1.0.217
 */

using UnityEngine;

namespace Zenject.Tests.Bindings.InstantiateCallback
{
    public class Foo : MonoBehaviour
    {
        public string Value
        {
            get; set;
        }

        public bool WasInjected
        {
            get;
            private set;
        }

        [Inject]
        public void Construct()
        {
            WasInjected = true;
        }
    }
}
