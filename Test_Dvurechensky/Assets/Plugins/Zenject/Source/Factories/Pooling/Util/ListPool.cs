/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 октября 2025 15:37:11
 * Version: 1.0.67
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
