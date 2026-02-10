/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 февраля 2026 10:31:59
 * Version: 1.0.173
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
