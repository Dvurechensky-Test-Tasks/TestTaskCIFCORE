/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 января 2026 07:54:44
 * Version: 1.0.155
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

