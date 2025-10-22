/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 октября 2025 13:45:11
 * Version: 1.0.62
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
