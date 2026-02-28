/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 февраля 2026 15:54:06
 * Version: 1.0.191
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
