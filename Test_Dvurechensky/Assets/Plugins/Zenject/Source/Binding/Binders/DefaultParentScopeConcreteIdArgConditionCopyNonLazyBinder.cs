/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 ноября 2025 12:24:57
 * Version: 1.0.95
 */

namespace Zenject
{
    [NoReflectionBaking]
    public class DefaultParentScopeConcreteIdArgConditionCopyNonLazyBinder : ScopeConcreteIdArgConditionCopyNonLazyBinder
    {
        public DefaultParentScopeConcreteIdArgConditionCopyNonLazyBinder(
            SubContainerCreatorBindInfo subContainerBindInfo, BindInfo bindInfo)
            : base(bindInfo)
        {
            SubContainerCreatorBindInfo = subContainerBindInfo;
        }

        protected SubContainerCreatorBindInfo SubContainerCreatorBindInfo
        {
            get; private set;
        }

        public ScopeConcreteIdArgConditionCopyNonLazyBinder WithDefaultGameObjectParent(string defaultParentName)
        {
            SubContainerCreatorBindInfo.DefaultParentName = defaultParentName;
            return this;
        }
    }
}
