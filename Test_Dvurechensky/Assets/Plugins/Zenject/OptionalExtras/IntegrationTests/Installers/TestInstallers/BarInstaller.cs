/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 апреля 2026 12:46:40
 * Version: 1.0.228
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
