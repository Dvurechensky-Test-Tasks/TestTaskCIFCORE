/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 декабря 2025 15:59:51
 * Version: 1.0.114
 */

using System.Collections.Generic;
using ModestTree;

namespace Zenject
{
    public class HashSetPool<T> : StaticMemoryPool<HashSet<T>>
    {
        static HashSetPool<T> _instance = new HashSetPool<T>();

        public HashSetPool()
        {
            OnSpawnMethod = OnSpawned;
            OnDespawnedMethod = OnDespawned;
        }

        public static HashSetPool<T> Instance
        {
            get { return _instance; }
        }

        static void OnSpawned(HashSet<T> items)
        {
            Assert.That(items.IsEmpty());
        }

        static void OnDespawned(HashSet<T> items)
        {
            items.Clear();
        }
    }
}
