/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 ноября 2025 06:52:09
 * Version: 1.0.82
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
