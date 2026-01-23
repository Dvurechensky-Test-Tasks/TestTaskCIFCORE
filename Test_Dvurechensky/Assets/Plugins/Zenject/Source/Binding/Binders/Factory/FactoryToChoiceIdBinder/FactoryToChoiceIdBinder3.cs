/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 января 2026 07:54:44
 * Version: 1.0.155
 */

namespace Zenject
{
    [NoReflectionBaking]
    public class FactoryToChoiceIdBinder<TParam1, TParam2, TParam3, TContract> : FactoryArgumentsToChoiceBinder<TParam1, TParam2, TParam3, TContract>
    {
        public FactoryToChoiceIdBinder(
            DiContainer bindContainer, BindInfo bindInfo, FactoryBindInfo factoryBindInfo)
            : base(bindContainer, bindInfo, factoryBindInfo)
        {
        }

        public FactoryArgumentsToChoiceBinder<TParam1, TParam2, TParam3, TContract> WithId(object identifier)
        {
            BindInfo.Identifier = identifier;
            return this;
        }
    }
}


