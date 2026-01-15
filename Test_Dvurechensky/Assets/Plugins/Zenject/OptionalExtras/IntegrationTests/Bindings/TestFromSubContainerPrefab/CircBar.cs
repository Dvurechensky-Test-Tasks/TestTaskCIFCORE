/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 января 2026 17:28:28
 * Version: 1.0.147
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
