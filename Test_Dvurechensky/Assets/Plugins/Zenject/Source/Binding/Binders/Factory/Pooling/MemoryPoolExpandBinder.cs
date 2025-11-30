/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 ноября 2025 14:36:10
 * Version: 1.0.101
 */

namespace Zenject
{
    [NoReflectionBaking]
    public class MemoryPoolExpandBinder<TContract> : FactoryArgumentsToChoiceBinder<TContract>
    {
        public MemoryPoolExpandBinder(
            DiContainer bindContainer, BindInfo bindInfo, FactoryBindInfo factoryBindInfo, MemoryPoolBindInfo poolBindInfo)
            : base(bindContainer, bindInfo, factoryBindInfo)
        {
            MemoryPoolBindInfo = poolBindInfo;

            ExpandByOneAtATime();
        }

        protected MemoryPoolBindInfo MemoryPoolBindInfo
        {
            get; private set;
        }

        public FactoryArgumentsToChoiceBinder<TContract> ExpandByOneAtATime()
        {
            MemoryPoolBindInfo.ExpandMethod = PoolExpandMethods.OneAtATime;
            return this;
        }

        public FactoryArgumentsToChoiceBinder<TContract> ExpandByDoubling()
        {
            MemoryPoolBindInfo.ExpandMethod = PoolExpandMethods.Double;
            return this;
        }
    }
}

