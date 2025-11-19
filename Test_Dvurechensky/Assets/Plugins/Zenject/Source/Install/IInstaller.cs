/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 19 ноября 2025 08:14:27
 * Version: 1.0.90
 */

namespace Zenject
{
    // We extract the interface so that monobehaviours can be installers
    public interface IInstaller
    {
        void InstallBindings();

        bool IsEnabled
        {
            get;
        }
    }

}
