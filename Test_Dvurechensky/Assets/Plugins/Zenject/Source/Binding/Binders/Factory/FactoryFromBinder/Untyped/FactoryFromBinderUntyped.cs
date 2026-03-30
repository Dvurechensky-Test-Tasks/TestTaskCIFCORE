/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 марта 2026 12:19:05
 * Version: 1.0.221
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
