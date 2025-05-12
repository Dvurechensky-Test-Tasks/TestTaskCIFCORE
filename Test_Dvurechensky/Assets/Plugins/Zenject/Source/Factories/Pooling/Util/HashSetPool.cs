/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 08:07:05
 * Version: 1.0.1
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
