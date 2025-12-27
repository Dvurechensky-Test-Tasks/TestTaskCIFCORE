/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 декабря 2025 15:50:16
 * Version: 1.0.128
 */

using System.Collections.Generic;

namespace Zenject
{
    public class ListPool<T> : StaticMemoryPool<List<T>>
    {
        static ListPool<T> _instance = new ListPool<T>();

        public ListPool()
        {
            OnDespawnedMethod = OnDespawned;
        }

        public static ListPool<T> Instance
        {
            get { return _instance; }
        }

        void OnDespawned(List<T> list)
        {
            list.Clear();
        }
    }
}
