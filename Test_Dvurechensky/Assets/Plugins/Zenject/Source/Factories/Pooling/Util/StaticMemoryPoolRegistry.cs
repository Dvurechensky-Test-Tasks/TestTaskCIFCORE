/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 марта 2026 10:51:37
 * Version: 1.0.222
 */

using System;
using System.Collections.Generic;
using ModestTree;

namespace Zenject
{
#if UNITY_EDITOR
    public static class StaticMemoryPoolRegistry
    {
        public static event Action<IMemoryPool> PoolAdded = delegate {};
        public static event Action<IMemoryPool> PoolRemoved = delegate {};

        readonly static List<IMemoryPool> _pools = new List<IMemoryPool>();

        public static IEnumerable<IMemoryPool> Pools
        {
            get { return _pools; }
        }

        public static void Add(IMemoryPool memoryPool)
        {
            _pools.Add(memoryPool);
            PoolAdded(memoryPool);
        }

        public static void Remove(IMemoryPool memoryPool)
        {
            _pools.RemoveWithConfirm(memoryPool);
            PoolRemoved(memoryPool);
        }
    }
#endif
}
