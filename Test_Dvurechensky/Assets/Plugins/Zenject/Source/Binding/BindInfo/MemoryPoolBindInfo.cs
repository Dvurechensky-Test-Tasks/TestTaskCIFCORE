/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 сентября 2025 11:44:34
 * Version: 1.0.15
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

