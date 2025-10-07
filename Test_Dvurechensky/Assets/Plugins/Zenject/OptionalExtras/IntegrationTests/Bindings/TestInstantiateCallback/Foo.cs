/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 октября 2025 08:37:12
 * Version: 1.0.46
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
