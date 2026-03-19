/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 19 марта 2026 06:50:28
 * Version: 1.0.209
 */

using System;
using UnityEngine;

namespace Zenject.Tests.Bindings.FromPrefabResource
{
    public class Jim : MonoBehaviour
    {
        [NonSerialized]
        [Inject]
        public Bob Bob;
    }
}
