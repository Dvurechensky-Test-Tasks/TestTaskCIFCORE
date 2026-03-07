/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 марта 2026 06:50:28
 * Version: 1.0.198
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

