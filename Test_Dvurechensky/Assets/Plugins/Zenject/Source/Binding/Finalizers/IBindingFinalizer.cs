/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 октября 2025 10:57:33
 * Version: 1.0.51
 */

namespace Zenject
{
    public interface IBindingFinalizer
    {
        BindingInheritanceMethods BindingInheritanceMethod
        {
            get;
        }

        void FinalizeBinding(DiContainer container);
    }
}
