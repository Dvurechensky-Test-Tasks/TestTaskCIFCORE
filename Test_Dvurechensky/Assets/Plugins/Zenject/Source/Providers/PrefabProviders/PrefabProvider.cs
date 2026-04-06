/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 апреля 2026 12:46:40
 * Version: 1.0.228
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


