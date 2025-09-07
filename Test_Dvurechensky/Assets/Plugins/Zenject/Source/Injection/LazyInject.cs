/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 сентября 2025 10:47:01
 * Version: 1.0.16
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
