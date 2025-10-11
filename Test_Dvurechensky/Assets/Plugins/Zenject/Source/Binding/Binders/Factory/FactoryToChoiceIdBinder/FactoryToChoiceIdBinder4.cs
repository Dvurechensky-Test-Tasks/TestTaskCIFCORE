/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 октября 2025 08:48:06
 * Version: 1.0.50
 */

namespace Zenject
{
    [NoReflectionBaking]
    public class FactoryToChoiceIdBinder<TParam1, TParam2, TParam3, TParam4, TContract> : FactoryArgumentsToChoiceBinder<TParam1, TParam2, TParam3, TParam4, TContract>
    {
        public FactoryToChoiceIdBinder(
            DiContainer bindContainer, BindInfo bindInfo, FactoryBindInfo factoryBindInfo)
            : base(bindContainer, bindInfo, factoryBindInfo)
        {
        }

        public FactoryArgumentsToChoiceBinder<TParam1, TParam2, TParam3, TParam4, TContract> WithId(object identifier)
        {
            BindInfo.Identifier = identifier;
            return this;
        }
    }
}
