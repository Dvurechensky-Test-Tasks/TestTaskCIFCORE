/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 января 2026 16:09:29
 * Version: 1.0.141
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
