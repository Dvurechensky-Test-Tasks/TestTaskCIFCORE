/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 февраля 2026 06:50:27
 * Version: 1.0.169
 */

using System;
using UnityEngine;

namespace Zenject.Tests.Bindings.FromPrefabResource
{
    public class Bob : MonoBehaviour
    {
        [NonSerialized]
        [Inject]
        public Jim Jim;
    }
}
