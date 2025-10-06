/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 октября 2025 06:50:27
 * Version: 1.0.45
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
