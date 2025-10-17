/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 октября 2025 13:16:36
 * Version: 1.0.56
 */

using System;

namespace Zenject
{
    public class ActionInstaller : Installer<ActionInstaller>
    {
        readonly Action<DiContainer> _installMethod;

        public ActionInstaller(Action<DiContainer> installMethod)
        {
            _installMethod = installMethod;
        }

        public override void InstallBindings()
        {
            _installMethod(Container);
        }
    }
}
