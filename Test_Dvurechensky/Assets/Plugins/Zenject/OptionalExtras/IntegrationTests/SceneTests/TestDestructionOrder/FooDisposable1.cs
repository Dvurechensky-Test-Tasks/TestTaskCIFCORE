/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 декабря 2025 12:47:40
 * Version: 1.0.102
 */

using System;
using UnityEngine;

namespace Zenject.Tests.TestDestructionOrder
{
    public class FooDisposable1 : IDisposable
    {
        public void Dispose()
        {
            Debug.Log("Destroyed FooDisposable1");
        }
    }
}
