/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 сентября 2025 15:28:32
 * Version: 1.0.21
 */

using UnityEngine;

namespace Zenject.Tests.AutoInjecter
{
    public class Foo
    {
        [Inject]
        public DiContainer Container;
    }

    public class Bar : MonoBehaviour
    {
        [Inject]
        public Foo Foo;

        public bool ConstructCalled;

        [Inject]
        public void Construct()
        {
            ConstructCalled = true;
        }
    }
}
