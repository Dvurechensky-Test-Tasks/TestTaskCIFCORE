/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 февраля 2026 13:22:35
 * Version: 1.0.181
 */

namespace Zenject
{
    [NoReflectionBaking]
    public class WithKernelDefaultParentScopeConcreteIdArgConditionCopyNonLazyBinder : DefaultParentScopeConcreteIdArgConditionCopyNonLazyBinder
    {
        public WithKernelDefaultParentScopeConcreteIdArgConditionCopyNonLazyBinder(
            SubContainerCreatorBindInfo subContainerBindInfo, BindInfo bindInfo)
            : base(subContainerBindInfo, bindInfo)
        {
        }

        public DefaultParentScopeConcreteIdArgConditionCopyNonLazyBinder WithKernel()
        {
            SubContainerCreatorBindInfo.CreateKernel = true;
            return this;
        }

        // This would be used in cases where you want to control the execution order for the
        // subcontainer
        public DefaultParentScopeConcreteIdArgConditionCopyNonLazyBinder WithKernel<TKernel>()
            where TKernel : Kernel
        {
            SubContainerCreatorBindInfo.CreateKernel = true;
            SubContainerCreatorBindInfo.KernelType = typeof(TKernel);
            return this;
        }
    }
}
