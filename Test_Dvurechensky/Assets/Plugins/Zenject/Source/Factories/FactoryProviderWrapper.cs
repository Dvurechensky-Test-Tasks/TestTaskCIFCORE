/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 сентября 2025 11:04:53
 * Version: 1.0.10
 */

using ModestTree;

namespace Zenject
{
    public class FactoryProviderWrapper<TContract> : IFactory<TContract>
    {
        readonly IProvider _provider;
        readonly InjectContext _injectContext;

        public FactoryProviderWrapper(
            IProvider provider, InjectContext injectContext)
        {
            Assert.That(injectContext.MemberType.DerivesFromOrEqual<TContract>());

            _provider = provider;
            _injectContext = injectContext;
        }

        public TContract Create()
        {
            var instance = _provider.GetInstance(_injectContext);

            if (_injectContext.Container.IsValidating)
            {
                // During validation it is sufficient to just call the _provider.GetInstance
                return default(TContract);
            }

            Assert.That(instance == null
                || instance.GetType().DerivesFromOrEqual(_injectContext.MemberType));

            return (TContract)instance;
        }
    }
}

