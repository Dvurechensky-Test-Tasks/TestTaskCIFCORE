/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 марта 2026 10:03:13
 * Version: 1.0.217
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

