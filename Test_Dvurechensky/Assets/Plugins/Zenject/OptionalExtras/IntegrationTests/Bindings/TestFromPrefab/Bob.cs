/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 октября 2025 10:56:40
 * Version: 1.0.55
 */

using System;
using UnityEngine;

namespace Zenject.Tests.Bindings.FromPrefab
{
    public class Bob : MonoBehaviour
    {
        [NonSerialized]
        [Inject]
        public Jim Jim;
    }
}
