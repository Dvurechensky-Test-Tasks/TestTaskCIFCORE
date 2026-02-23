/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 февраля 2026 14:21:11
 * Version: 1.0.186
 */

using System;
using UnityEngine;

namespace Zenject.Tests.Bindings.FromPrefab
{
    public class Jim : MonoBehaviour
    {
        [NonSerialized]
        [Inject]
        public Bob Bob;
    }
}
