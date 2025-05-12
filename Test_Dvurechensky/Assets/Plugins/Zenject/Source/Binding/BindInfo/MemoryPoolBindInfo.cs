/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 08:07:05
 * Version: 1.0.1
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

