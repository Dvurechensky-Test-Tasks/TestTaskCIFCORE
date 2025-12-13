/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 декабря 2025 15:59:51
 * Version: 1.0.114
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
