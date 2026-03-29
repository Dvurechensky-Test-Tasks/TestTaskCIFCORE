/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 марта 2026 11:11:52
 * Version: 1.0.220
 */

namespace Zenject
{
    [NoReflectionBaking]
    public class ConcreteIdBinderGeneric<TContract> : ConcreteBinderGeneric<TContract>
    {
        public ConcreteIdBinderGeneric(
            DiContainer bindContainer, BindInfo bindInfo,
            BindStatement bindStatement)
            : base(bindContainer, bindInfo, bindStatement)
        {
        }

        public ConcreteBinderGeneric<TContract> WithId(object identifier)
        {
            BindInfo.Identifier = identifier;
            return this;
        }
    }
}

