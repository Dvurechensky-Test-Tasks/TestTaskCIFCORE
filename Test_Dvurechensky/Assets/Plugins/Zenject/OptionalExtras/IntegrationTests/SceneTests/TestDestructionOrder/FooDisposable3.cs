/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 января 2026 06:50:28
 * Version: 1.0.162
 */

using System;
using UnityEngine;

namespace Zenject.Tests.TestDestructionOrder
{
    public class FooDisposable3 : IDisposable
    {
        public void Dispose()
        {
            Debug.Log("Destroyed FooDisposable3");
        }
    }
}
