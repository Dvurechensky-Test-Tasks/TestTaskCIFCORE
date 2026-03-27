/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 марта 2026 11:49:53
 * Version: 1.0.218
 */

namespace Zenject.Tests.AutoLoadSceneTests
{
    public class Scene1Installer : MonoInstaller<Scene1Installer>
    {
        public override void InstallBindings()
        {
            Container.Bind<Qux>().AsSingle();
        }
    }
}
