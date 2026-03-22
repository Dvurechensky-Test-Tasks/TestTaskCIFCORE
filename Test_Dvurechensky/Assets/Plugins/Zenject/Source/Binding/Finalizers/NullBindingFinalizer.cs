/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 марта 2026 09:59:34
 * Version: 1.0.212
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

