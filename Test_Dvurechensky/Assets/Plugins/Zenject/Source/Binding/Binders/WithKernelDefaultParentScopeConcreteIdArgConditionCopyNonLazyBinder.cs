/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 декабря 2025 14:55:01
 * Version: 1.0.106
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
