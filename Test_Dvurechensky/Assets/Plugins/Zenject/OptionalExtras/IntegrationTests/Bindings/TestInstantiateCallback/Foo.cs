/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 декабря 2025 09:29:10
 * Version: 1.0.126
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
