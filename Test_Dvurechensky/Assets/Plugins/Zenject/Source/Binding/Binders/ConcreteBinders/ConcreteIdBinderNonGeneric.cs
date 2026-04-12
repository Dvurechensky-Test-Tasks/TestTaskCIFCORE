/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 апреля 2026 14:13:56
 * Version: 1.0.234
 */

namespace Zenject
{
    [NoReflectionBaking]
    public class ConcreteIdBinderNonGeneric : ConcreteBinderNonGeneric
    {
        public ConcreteIdBinderNonGeneric(
            DiContainer bindContainer, BindInfo bindInfo,
            BindStatement bindStatement)
            : base(bindContainer, bindInfo, bindStatement)
        {
        }

        public ConcreteBinderNonGeneric WithId(object identifier)
        {
            BindInfo.Identifier = identifier;
            return this;
        }
    }
}

