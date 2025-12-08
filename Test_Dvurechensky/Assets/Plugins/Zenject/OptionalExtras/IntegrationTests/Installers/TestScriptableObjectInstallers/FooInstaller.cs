/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 декабря 2025 13:05:34
 * Version: 1.0.109
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
