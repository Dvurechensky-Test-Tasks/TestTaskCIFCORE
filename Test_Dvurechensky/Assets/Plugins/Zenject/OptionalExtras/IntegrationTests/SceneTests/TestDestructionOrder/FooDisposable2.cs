/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 сентября 2025 15:28:32
 * Version: 1.0.21
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
