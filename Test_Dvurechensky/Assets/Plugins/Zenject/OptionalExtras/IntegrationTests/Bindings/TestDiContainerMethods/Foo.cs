/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 апреля 2026 12:46:40
 * Version: 1.0.228
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
