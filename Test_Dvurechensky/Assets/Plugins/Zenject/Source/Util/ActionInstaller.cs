/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 февраля 2026 10:31:59
 * Version: 1.0.173
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
