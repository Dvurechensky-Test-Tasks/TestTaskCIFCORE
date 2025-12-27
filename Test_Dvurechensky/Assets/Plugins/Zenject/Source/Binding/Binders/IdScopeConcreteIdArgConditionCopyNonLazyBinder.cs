/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 декабря 2025 15:50:16
 * Version: 1.0.128
 */

namespace Zenject
{
    [NoReflectionBaking]
    public class IdScopeConcreteIdArgConditionCopyNonLazyBinder : ScopeConcreteIdArgConditionCopyNonLazyBinder
    {
        public IdScopeConcreteIdArgConditionCopyNonLazyBinder(BindInfo bindInfo)
            : base(bindInfo)
        {
        }

        public ScopeConcreteIdArgConditionCopyNonLazyBinder WithId(object identifier)
        {
            BindInfo.Identifier = identifier;
            return this;
        }
    }
}
