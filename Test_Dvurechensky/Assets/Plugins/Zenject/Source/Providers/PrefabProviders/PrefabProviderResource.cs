/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 декабря 2025 15:23:43
 * Version: 1.0.118
 */

#if !NOT_UNITY3D

using ModestTree;
using UnityEngine;

namespace Zenject
{
    [NoReflectionBaking]
    public class PrefabProviderResource : IPrefabProvider
    {
        readonly string _resourcePath;

        public PrefabProviderResource(string resourcePath)
        {
            _resourcePath = resourcePath;
        }

        public UnityEngine.Object GetPrefab(InjectContext context)
        {
            var prefab = (GameObject)Resources.Load(_resourcePath);

            Assert.That(prefab != null,
                "Expected to find prefab at resource path '{0}'", _resourcePath);

            return prefab;
        }
    }
}

#endif

