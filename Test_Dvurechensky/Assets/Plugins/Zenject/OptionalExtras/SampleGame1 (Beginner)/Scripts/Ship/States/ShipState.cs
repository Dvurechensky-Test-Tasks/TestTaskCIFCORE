/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 декабря 2025 15:50:16
 * Version: 1.0.128
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
