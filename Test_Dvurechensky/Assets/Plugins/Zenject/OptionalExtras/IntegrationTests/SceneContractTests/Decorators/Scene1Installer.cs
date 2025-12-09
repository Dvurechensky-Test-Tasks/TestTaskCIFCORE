/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 декабря 2025 13:32:01
 * Version: 1.0.110
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
