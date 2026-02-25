/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 февраля 2026 13:59:57
 * Version: 1.0.188
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

