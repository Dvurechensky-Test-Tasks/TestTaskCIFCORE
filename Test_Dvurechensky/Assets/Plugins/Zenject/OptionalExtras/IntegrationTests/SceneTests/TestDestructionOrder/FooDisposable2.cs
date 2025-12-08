/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 декабря 2025 13:05:34
 * Version: 1.0.109
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
