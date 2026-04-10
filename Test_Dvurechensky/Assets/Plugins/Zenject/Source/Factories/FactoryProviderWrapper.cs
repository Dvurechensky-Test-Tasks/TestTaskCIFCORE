/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 апреля 2026 12:30:12
 * Version: 1.0.232
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

