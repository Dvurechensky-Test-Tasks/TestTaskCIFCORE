/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 марта 2026 10:10:08
 * Version: 1.0.219
 */

using ModestTree;

namespace Zenject.Internal
{
    [NoReflectionBaking]
    public class LookupId
    {
        public IProvider Provider;
        public BindingId BindingId;

        public LookupId()
        {
        }

        public LookupId(IProvider provider, BindingId bindingId)
        {
            Assert.IsNotNull(provider);
            Assert.IsNotNull(bindingId);

            Provider = provider;
            BindingId = bindingId;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + Provider.GetHashCode();
            hash = hash * 23 + BindingId.GetHashCode();
            return hash;
        }

        public void Reset()
        {
            Provider = null;
            BindingId.Type = null;
            BindingId.Identifier = null;
        }
    }
}
