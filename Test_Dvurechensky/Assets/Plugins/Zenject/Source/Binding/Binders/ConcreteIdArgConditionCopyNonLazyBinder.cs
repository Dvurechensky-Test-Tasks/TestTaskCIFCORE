/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 октября 2025 10:13:28
 * Version: 1.0.53
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
