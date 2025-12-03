/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 декабря 2025 11:18:54
 * Version: 1.0.104
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

