/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 января 2026 11:55:40
 * Version: 1.0.149
 */

namespace Zenject.Tests.Installers.Installers
{
    public class QuxInstaller : Installer<string, float, int, QuxInstaller>
    {
        string _p1;

        [Inject]
        public void Construct(string p1, float p2, int p3)
        {
            _p1 = p1;
        }

        public override void InstallBindings()
        {
            Container.BindInstance(_p1);
        }
    }
}
