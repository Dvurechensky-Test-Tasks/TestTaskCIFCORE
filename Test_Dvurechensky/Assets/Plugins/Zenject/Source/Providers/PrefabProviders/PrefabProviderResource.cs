/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 февраля 2026 10:31:34
 * Version: 1.0.175
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

