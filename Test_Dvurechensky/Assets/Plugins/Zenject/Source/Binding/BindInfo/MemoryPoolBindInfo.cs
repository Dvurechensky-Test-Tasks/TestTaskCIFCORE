/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 ноября 2025 09:29:31
 * Version: 1.0.92
 */

namespace Zenject
{
    public enum PoolExpandMethods
    {
        OneAtATime,
        Double,
        Disabled
    }

    [NoReflectionBaking]
    public class MemoryPoolBindInfo
    {
        public MemoryPoolBindInfo()
        {
            ExpandMethod = PoolExpandMethods.OneAtATime;
            MaxSize = int.MaxValue;
        }

        public PoolExpandMethods ExpandMethod
        {
            get; set;
        }

        public int InitialSize
        {
            get; set;
        }

        public int MaxSize
        {
            get; set;
        }
    }
}

