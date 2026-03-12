/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 марта 2026 06:50:29
 * Version: 1.0.203
 */

namespace Zenject
{
    [NoReflectionBaking]
    public class FactoryToChoiceIdBinder<TParam1, TParam2, TContract> : FactoryArgumentsToChoiceBinder<TParam1, TParam2, TContract>
    {
        public FactoryToChoiceIdBinder(
            DiContainer bindContainer, BindInfo bindInfo, FactoryBindInfo factoryBindInfo)
            : base(bindContainer, bindInfo, factoryBindInfo)
        {
        }

        public FactoryArgumentsToChoiceBinder<TParam1, TParam2, TContract> WithId(object identifier)
        {
            BindInfo.Identifier = identifier;
            return this;
        }
    }
}

