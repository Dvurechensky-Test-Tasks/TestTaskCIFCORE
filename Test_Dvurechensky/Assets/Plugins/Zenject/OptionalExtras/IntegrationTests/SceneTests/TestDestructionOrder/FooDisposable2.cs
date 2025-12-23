/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 декабря 2025 10:46:12
 * Version: 1.0.124
 */

using System;
using UnityEngine;

namespace Zenject.Tests.TestDestructionOrder
{
    public class FooDisposable2 : IDisposable
    {
        public void Dispose()
        {
            Debug.Log("Destroyed FooDisposable2");
        }
    }
}
