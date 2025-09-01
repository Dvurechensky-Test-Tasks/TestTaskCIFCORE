/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 сентября 2025 11:04:53
 * Version: 1.0.10
 */

using System;
using ModestTree;

namespace Zenject
{
    [NoReflectionBaking]
    public class SingleProviderBindingFinalizer : ProviderBindingFinalizer
    {
        readonly Func<DiContainer, Type, IProvider> _providerFactory;

        public SingleProviderBindingFinalizer(
            BindInfo bindInfo, Func<DiContainer, Type, IProvider> providerFactory)
            : base(bindInfo)
        {
            _providerFactory = providerFactory;
        }

        protected override void OnFinalizeBinding(DiContainer container)
        {
            if (BindInfo.ToChoice == ToChoices.Self)
            {
                Assert.IsEmpty(BindInfo.ToTypes);

                RegisterProviderPerContract(container, _providerFactory);
            }
            else
            {
                // Empty sometimes when using convention based bindings
                if (!BindInfo.ToTypes.IsEmpty())
                {
                    RegisterProvidersForAllContractsPerConcreteType(
                        container, BindInfo.ToTypes, _providerFactory);
                }
            }
        }
    }
}
