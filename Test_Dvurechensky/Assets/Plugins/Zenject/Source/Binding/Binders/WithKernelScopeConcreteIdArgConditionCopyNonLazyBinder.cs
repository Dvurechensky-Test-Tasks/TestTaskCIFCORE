/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 декабря 2025 12:55:31
 * Version: 1.0.108
 */

namespace Zenject
{
    [NoReflectionBaking]
    public class WithKernelScopeConcreteIdArgConditionCopyNonLazyBinder : ScopeConcreteIdArgConditionCopyNonLazyBinder
    {
        SubContainerCreatorBindInfo _subContainerBindInfo;

        public WithKernelScopeConcreteIdArgConditionCopyNonLazyBinder(
            SubContainerCreatorBindInfo subContainerBindInfo, BindInfo bindInfo)
            : base(bindInfo)
        {
            _subContainerBindInfo = subContainerBindInfo;
        }

        public ScopeConcreteIdArgConditionCopyNonLazyBinder WithKernel()
        {
            _subContainerBindInfo.CreateKernel = true;
            return this;
        }

        // This would be used in cases where you want to control the execution order for the
        // subcontainer
        public ScopeConcreteIdArgConditionCopyNonLazyBinder WithKernel<TKernel>()
            where TKernel : Kernel
        {
            _subContainerBindInfo.CreateKernel = true;
            _subContainerBindInfo.KernelType = typeof(TKernel);
            return this;
        }
    }
}
