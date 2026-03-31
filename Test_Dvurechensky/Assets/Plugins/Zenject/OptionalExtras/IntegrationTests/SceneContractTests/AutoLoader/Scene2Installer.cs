/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 марта 2026 10:51:37
 * Version: 1.0.222
 */

namespace Zenject.Tests.AutoLoadSceneTests
{
    public class Scene2Installer : MonoInstaller<Scene2Installer>
    {
        public override void InstallBindings()
        {
            Container.Bind<Bar>().AsSingle();
        }
    }
}
