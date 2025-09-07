/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 сентября 2025 10:47:01
 * Version: 1.0.16
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
