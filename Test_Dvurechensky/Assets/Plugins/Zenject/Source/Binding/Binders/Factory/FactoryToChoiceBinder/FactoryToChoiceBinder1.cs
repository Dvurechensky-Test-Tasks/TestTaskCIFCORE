/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 сентября 2025 17:13:59
 * Version: 1.0.32
 */

using ModestTree;

namespace Zenject
{
    [NoReflectionBaking]
    public class FactoryToChoiceBinder<TParam1, TContract> : FactoryFromBinder<TParam1, TContract>
    {
        public FactoryToChoiceBinder(
            DiContainer bindContainer, BindInfo bindInfo, FactoryBindInfo factoryBindInfo)
            : base(bindContainer, bindInfo, factoryBindInfo)
        {
        }

        // Note that this is the default, so not necessary to call
        public FactoryFromBinder<TParam1, TContract> ToSelf()
        {
            Assert.IsEqual(BindInfo.ToChoice, ToChoices.Self);
            return this;
        }

        public FactoryFromBinder<TParam1, TConcrete> To<TConcrete>()
            where TConcrete : TContract
        {
            BindInfo.ToChoice = ToChoices.Concrete;
            BindInfo.ToTypes.Clear();
            BindInfo.ToTypes.Add(typeof(TConcrete));

            return new FactoryFromBinder<TParam1, TConcrete>(BindContainer, BindInfo, FactoryBindInfo);
        }
    }
}
