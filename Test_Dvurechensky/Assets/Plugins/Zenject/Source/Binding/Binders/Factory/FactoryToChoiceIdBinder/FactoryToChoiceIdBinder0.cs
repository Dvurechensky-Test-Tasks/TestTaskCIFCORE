/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 19 октября 2025 13:34:20
 * Version: 1.0.58
 */

namespace Zenject
{
    [NoReflectionBaking]
    public class FactoryToChoiceIdBinder<TContract> : FactoryArgumentsToChoiceBinder<TContract>
    {
        public FactoryToChoiceIdBinder(
            DiContainer container, BindInfo bindInfo, FactoryBindInfo factoryBindInfo)
            : base(container, bindInfo, factoryBindInfo)
        {
        }

        public FactoryArgumentsToChoiceBinder<TContract> WithId(object identifier)
        {
            BindInfo.Identifier = identifier;
            return this;
        }
    }
}


