/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 ноября 2025 10:15:56
 * Version: 1.0.93
 */

using System;
using UnityEngine;

namespace Zenject.Asteroids
{
    public abstract class ShipState : IDisposable
    {
        public abstract void Update();

        public virtual void Start()
        {
            // optionally overridden
        }

        public virtual void Dispose()
        {
            // optionally overridden
        }

        public virtual void OnTriggerEnter(Collider other)
        {
            // optionally overridden
        }
    }
}
