/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 марта 2026 09:59:34
 * Version: 1.0.212
 */

namespace Zenject
{
    public abstract class InstallerBase : IInstaller
    {
        [Inject]
        DiContainer _container = null;

        protected DiContainer Container
        {
            get { return _container; }
        }

        public virtual bool IsEnabled
        {
            get { return true; }
        }

        public abstract void InstallBindings();
    }
}

