/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 августа 2025 08:33:25
 * Version: 1.0.8
 */

namespace Zenject
{
    [NoReflectionBaking]
    public class DecoratorToChoiceFromBinder<TContract>
    {
        DiContainer _bindContainer;
        BindInfo _bindInfo;
        FactoryBindInfo _factoryBindInfo;

        public DecoratorToChoiceFromBinder(
            DiContainer bindContainer, BindInfo bindInfo, FactoryBindInfo factoryBindInfo)
        {
            _bindContainer = bindContainer;
            _bindInfo = bindInfo;
            _factoryBindInfo = factoryBindInfo;
        }

        public FactoryFromBinder<TContract, TConcrete> With<TConcrete>()
            where TConcrete : TContract
        {
            _bindInfo.ToChoice = ToChoices.Concrete;
            _bindInfo.ToTypes.Clear();
            _bindInfo.ToTypes.Add(typeof(TConcrete));

            return new FactoryFromBinder<TContract, TConcrete>(
                _bindContainer, _bindInfo, _factoryBindInfo);
        }
    }
}
