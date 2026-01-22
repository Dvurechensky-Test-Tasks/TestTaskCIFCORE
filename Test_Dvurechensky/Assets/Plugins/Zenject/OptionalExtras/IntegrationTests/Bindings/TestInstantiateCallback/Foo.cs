/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 января 2026 06:50:28
 * Version: 1.0.154
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
