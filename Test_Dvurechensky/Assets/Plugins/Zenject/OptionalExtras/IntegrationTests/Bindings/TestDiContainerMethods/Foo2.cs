/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 сентября 2025 08:07:37
 * Version: 1.0.13
 */

using UnityEngine;

namespace Zenject.Tests.Bindings.DiContainerMethods
{
    //[CreateAssetMenu(fileName = "Foo2", menuName = "Test/Foo2")]
    public class Foo2 : ScriptableObject
    {
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
