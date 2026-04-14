/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 апреля 2026 12:23:01
 * Version: 1.0.236
 */

namespace Zenject
{
    [NoReflectionBaking]
    public class NullBindingFinalizer : IBindingFinalizer
    {
        public BindingInheritanceMethods BindingInheritanceMethod
        {
            get { return BindingInheritanceMethods.None; }
        }

        public void FinalizeBinding(DiContainer container)
        {
            // Do nothing
        }
    }
}

