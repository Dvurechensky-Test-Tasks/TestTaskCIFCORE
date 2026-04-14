/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 апреля 2026 12:23:01
 * Version: 1.0.236
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
