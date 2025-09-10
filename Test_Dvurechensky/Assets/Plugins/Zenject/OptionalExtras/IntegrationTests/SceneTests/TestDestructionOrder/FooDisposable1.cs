/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 сентября 2025 14:28:34
 * Version: 1.0.19
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
