/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 октября 2025 11:17:32
 * Version: 1.0.59
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
