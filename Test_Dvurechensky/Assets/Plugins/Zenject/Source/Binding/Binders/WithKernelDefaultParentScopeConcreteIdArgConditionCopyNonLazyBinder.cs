/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 февраля 2026 07:40:37
 * Version: 1.0.168
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
