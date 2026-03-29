/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 марта 2026 11:11:52
 * Version: 1.0.220
 */

namespace Zenject.Tests.Factories.BindFactoryOne
{
    public class FooInstaller : MonoInstaller
    {
        string _param1;

        [Inject]
        public void Init(string param1)
        {
            _param1 = param1;
        }

        public override void InstallBindings()
        {
            Container.BindInstance(_param1).WhenInjectedInto<Foo>();
            Container.Bind<Foo>().FromNewComponentOnNewGameObject().AsTransient();
        }
    }
}
