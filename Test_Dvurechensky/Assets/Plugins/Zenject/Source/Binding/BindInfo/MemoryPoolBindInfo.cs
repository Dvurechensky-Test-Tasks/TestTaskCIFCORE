/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 февраля 2026 13:20:55
 * Version: 1.0.187
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

