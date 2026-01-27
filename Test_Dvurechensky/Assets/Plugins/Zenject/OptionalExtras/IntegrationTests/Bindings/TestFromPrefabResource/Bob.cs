/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 января 2026 10:38:53
 * Version: 1.0.159
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
