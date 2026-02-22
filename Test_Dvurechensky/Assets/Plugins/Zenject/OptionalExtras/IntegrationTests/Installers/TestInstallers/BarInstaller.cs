/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 февраля 2026 13:30:34
 * Version: 1.0.185
 */

namespace Zenject.Tests.Installers.Installers
{
    public class BarInstaller : Installer<string, BarInstaller>
    {
        string _value;

        [Inject]
        public void Construct(string value)
        {
            _value = value;
        }

        public override void InstallBindings()
        {
            Container.BindInstance(_value);
        }
    }
}
