/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 августа 2025 07:05:58
 * Version: 1.0.6
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
