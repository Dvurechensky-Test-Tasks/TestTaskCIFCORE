/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 апреля 2026 13:37:16
 * Version: 1.0.233
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
