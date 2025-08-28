/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 августа 2025 07:05:58
 * Version: 1.0.6
 */

namespace Zenject.Tests.Installers.MonoInstallers
{
    public class QuxInstaller : MonoInstaller<string, float, int, QuxInstaller>
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
