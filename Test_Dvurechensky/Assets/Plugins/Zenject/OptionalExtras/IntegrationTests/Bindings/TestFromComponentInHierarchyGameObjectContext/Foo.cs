/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 марта 2026 09:54:23
 * Version: 1.0.199
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
