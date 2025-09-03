/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 сентября 2025 07:55:35
 * Version: 1.0.12
 */

using System;
using System.Linq;
using ModestTree;

namespace Zenject
{
    [NoReflectionBaking]
    public class ConditionCopyNonLazyBinder : CopyNonLazyBinder
    {
        public ConditionCopyNonLazyBinder(BindInfo bindInfo)
            : base(bindInfo)
        {
        }

        public CopyNonLazyBinder When(BindingCondition condition)
        {
            BindInfo.Condition = condition;
            return this;
        }

        public CopyNonLazyBinder WhenInjectedIntoInstance(object instance)
        {
            return When(r => ReferenceEquals(r.ObjectInstance, instance));
        }

        public CopyNonLazyBinder WhenInjectedInto(params Type[] targets)
        {
            return When(r => targets.Where(x => r.ObjectType != null && r.ObjectType.DerivesFromOrEqual(x)).Any());
        }

        public CopyNonLazyBinder WhenInjectedInto<T>()
        {
            return When(r => r.ObjectType != null && r.ObjectType.DerivesFromOrEqual(typeof(T)));
        }

        public CopyNonLazyBinder WhenNotInjectedInto<T>()
        {
            return When(r => r.ObjectType == null || !r.ObjectType.DerivesFromOrEqual(typeof(T)));
        }
    }
}
