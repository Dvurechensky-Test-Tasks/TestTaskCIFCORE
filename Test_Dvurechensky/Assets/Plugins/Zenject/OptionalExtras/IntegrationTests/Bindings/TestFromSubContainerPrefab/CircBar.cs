/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 марта 2026 06:50:29
 * Version: 1.0.203
 */

using UnityEngine;

namespace Zenject.Tests.Bindings.FromSubContainerPrefab
{
    public class CircBar : MonoBehaviour
    {
        [Inject]
        public CircFoo Foo;
    }
}
