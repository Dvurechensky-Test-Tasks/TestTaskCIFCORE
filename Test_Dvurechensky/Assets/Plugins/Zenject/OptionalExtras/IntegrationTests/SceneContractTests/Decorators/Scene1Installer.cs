/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 октября 2025 15:37:11
 * Version: 1.0.67
 */

namespace Zenject.Tests.DecoratorTests
{
    public class Scene1Installer : MonoInstaller<Scene1Installer>
    {
        public override void InstallBindings()
        {
            Container.Bind<Bar>().AsSingle();
        }
    }
}
