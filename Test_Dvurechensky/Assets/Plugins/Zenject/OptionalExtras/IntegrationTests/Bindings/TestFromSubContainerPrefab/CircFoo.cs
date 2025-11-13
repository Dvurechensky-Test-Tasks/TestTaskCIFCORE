/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 ноября 2025 06:50:27
 * Version: 1.0.84
 */

using UnityEngine;

namespace Zenject.Tests.Bindings.FromSubContainerPrefab
{
    public class CircFoo : MonoBehaviour
    {
        [Inject]
        public CircBar Bar;
    }
}
