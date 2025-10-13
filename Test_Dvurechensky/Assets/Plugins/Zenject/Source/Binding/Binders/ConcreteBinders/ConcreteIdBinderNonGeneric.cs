/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 октября 2025 10:00:48
 * Version: 1.0.52
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

