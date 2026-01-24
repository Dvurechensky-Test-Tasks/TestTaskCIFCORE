/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 января 2026 09:16:42
 * Version: 1.0.156
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
