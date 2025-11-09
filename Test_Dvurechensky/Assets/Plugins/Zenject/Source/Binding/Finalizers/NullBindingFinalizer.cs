/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 ноября 2025 06:50:49
 * Version: 1.0.80
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

