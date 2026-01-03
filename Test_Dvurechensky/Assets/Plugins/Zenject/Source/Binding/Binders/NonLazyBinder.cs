/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 января 2026 14:58:24
 * Version: 1.0.135
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
