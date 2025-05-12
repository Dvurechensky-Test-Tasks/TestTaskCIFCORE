/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 08:07:05
 * Version: 1.0.1
 */

#if !NOT_UNITY3D

using ModestTree;

namespace Zenject
{
    [NoReflectionBaking]
    public class PrefabProvider : IPrefabProvider
    {
        readonly UnityEngine.Object _prefab;

        public PrefabProvider(UnityEngine.Object prefab)
        {
            Assert.IsNotNull(prefab);
            _prefab = prefab;
        }

        public UnityEngine.Object GetPrefab(InjectContext _)
        {
            return _prefab;
        }
    }
}

#endif


