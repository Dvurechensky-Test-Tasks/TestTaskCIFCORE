/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 марта 2026 10:03:13
 * Version: 1.0.217
 */

namespace Zenject
{
    [NoReflectionBaking]
    public class NonLazyBinder : IfNotBoundBinder
    {
        public NonLazyBinder(BindInfo bindInfo)
            : base(bindInfo)
        {
        }

        public IfNotBoundBinder NonLazy()
        {
            BindInfo.NonLazy = true;
            return this;
        }

        public IfNotBoundBinder Lazy()
        {
            BindInfo.NonLazy = false;
            return this;
        }
    }
}
