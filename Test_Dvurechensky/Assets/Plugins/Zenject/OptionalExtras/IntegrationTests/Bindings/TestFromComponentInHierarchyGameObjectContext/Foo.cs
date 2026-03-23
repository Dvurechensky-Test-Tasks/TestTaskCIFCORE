/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 марта 2026 13:10:06
 * Version: 1.0.214
 */

using System;
using UnityEngine;

namespace Zenject.Tests.Bindings.FromComponentInHierarchyGameObjectContext
{
    public class Foo : MonoBehaviour
    {
        [NonSerialized]
        [Inject]
        public Gorp Gorp;
    }
}
