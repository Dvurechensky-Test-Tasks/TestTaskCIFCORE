/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 февраля 2026 13:59:57
 * Version: 1.0.188
 */

using System;

namespace Zenject
{
    [NoReflectionBaking]
    public class FactoryFromBinderUntyped : FactoryFromBinderBase
    {
        public FactoryFromBinderUntyped(
            DiContainer bindContainer, Type contractType, BindInfo bindInfo, FactoryBindInfo factoryBindInfo)
            : base(bindContainer, contractType, bindInfo, factoryBindInfo)
        {
        }

        // TODO - add similar methods found in FactoryFromBinder<>
    }
}
