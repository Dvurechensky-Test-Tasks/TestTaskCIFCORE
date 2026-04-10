/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 апреля 2026 12:30:12
 * Version: 1.0.232
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
