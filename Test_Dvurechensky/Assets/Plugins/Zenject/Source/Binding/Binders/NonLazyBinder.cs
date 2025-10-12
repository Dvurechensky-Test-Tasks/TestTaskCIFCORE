/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 октября 2025 10:57:33
 * Version: 1.0.51
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
