/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 февраля 2026 10:31:59
 * Version: 1.0.173
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

