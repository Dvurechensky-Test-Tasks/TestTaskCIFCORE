/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 декабря 2025 09:29:10
 * Version: 1.0.126
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
