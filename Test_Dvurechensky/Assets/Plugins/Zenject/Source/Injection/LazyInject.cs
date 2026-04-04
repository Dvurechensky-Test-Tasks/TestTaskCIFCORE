/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 апреля 2026 12:57:33
 * Version: 1.0.226
 */

using ModestTree;

namespace Zenject
{
    [ZenjectAllowDuringValidation]
    [NoReflectionBaking]
    public class LazyInject<T> : IValidatable
    {
        readonly DiContainer _container;
        readonly InjectContext _context;

        bool _hasValue;
        T _value;

        public LazyInject(DiContainer container, InjectContext context)
        {
            Assert.DerivesFromOrEqual<T>(context.MemberType);

            _container = container;
            _context = context;
        }

        void IValidatable.Validate()
        {
            _container.Resolve(_context);
        }

        public T Value
        {
            get
            {
                if (!_hasValue)
                {
                    _value = (T)_container.Resolve(_context);
                    _hasValue = true;
                }

                return _value;
            }
        }
    }
}
