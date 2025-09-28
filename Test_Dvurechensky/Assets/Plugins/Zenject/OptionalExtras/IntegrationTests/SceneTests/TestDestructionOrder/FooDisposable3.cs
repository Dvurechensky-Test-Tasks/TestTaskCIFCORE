/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 сентября 2025 21:12:51
 * Version: 1.0.37
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
