/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 октября 2025 11:17:32
 * Version: 1.0.59
 */

namespace Zenject.Tests.Installers.ScriptableObjectInstallers
{
    public class Foo
    {
    }

    //[CreateAssetMenu(fileName = "FooInstaller", menuName = "Installers/FooInstaller")]
    public class FooInstaller : ScriptableObjectInstaller<FooInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<Foo>().AsSingle().NonLazy();
        }
    }
}
