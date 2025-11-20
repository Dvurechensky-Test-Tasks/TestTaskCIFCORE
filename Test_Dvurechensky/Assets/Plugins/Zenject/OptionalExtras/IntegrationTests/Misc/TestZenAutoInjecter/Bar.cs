/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 ноября 2025 12:20:36
 * Version: 1.0.91
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
