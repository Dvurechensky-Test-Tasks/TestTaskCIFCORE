/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 сентября 2025 10:47:01
 * Version: 1.0.16
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
