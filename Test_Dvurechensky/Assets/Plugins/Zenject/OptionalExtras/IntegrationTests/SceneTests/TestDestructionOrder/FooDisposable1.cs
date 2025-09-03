/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 сентября 2025 07:55:35
 * Version: 1.0.12
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
