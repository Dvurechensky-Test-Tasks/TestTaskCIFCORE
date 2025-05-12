/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 08:07:05
 * Version: 1.0.1
 */

#if !NOT_UNITY3D

using ModestTree;
using UnityEngine;
using System;

namespace Zenject
{
    [NoReflectionBaking]
    public class PrefabProviderCustom : IPrefabProvider
    {
        readonly Func<InjectContext, UnityEngine.Object> _getter;

        public PrefabProviderCustom(Func<InjectContext, UnityEngine.Object> getter)
        {
            _getter = getter;
        }

        public UnityEngine.Object GetPrefab(InjectContext context)
        {
            var prefab = _getter(context);
            Assert.That(prefab != null, "Custom prefab provider returned null");
            return prefab;
        }
    }
}

#endif

