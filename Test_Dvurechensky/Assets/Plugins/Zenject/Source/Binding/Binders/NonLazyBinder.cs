/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 декабря 2025 10:56:09
 * Version: 1.0.132
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
