/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 ноября 2025 06:52:09
 * Version: 1.0.82
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
