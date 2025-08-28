/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 августа 2025 07:05:58
 * Version: 1.0.6
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
