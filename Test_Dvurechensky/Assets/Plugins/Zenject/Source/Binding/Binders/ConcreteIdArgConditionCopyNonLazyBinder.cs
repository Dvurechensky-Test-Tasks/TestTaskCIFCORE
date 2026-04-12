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
    public class ConcreteIdArgConditionCopyNonLazyBinder : ArgConditionCopyNonLazyBinder
    {
        public ConcreteIdArgConditionCopyNonLazyBinder(BindInfo bindInfo)
            : base(bindInfo)
        {
        }

        public ArgConditionCopyNonLazyBinder WithConcreteId(object id)
        {
            BindInfo.ConcreteIdentifier = id;
            return this;
        }
    }
}
