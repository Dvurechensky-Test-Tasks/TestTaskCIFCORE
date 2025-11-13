/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 ноября 2025 06:50:27
 * Version: 1.0.84
 */

using UnityEngine;

namespace Zenject.Tests.Bindings.DiContainerMethods
{
    public interface IFoo
    {
    }

    public class Foo : MonoBehaviour, IFoo
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
