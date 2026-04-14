/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 апреля 2026 12:23:01
 * Version: 1.0.236
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


