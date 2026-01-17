/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 января 2026 11:55:40
 * Version: 1.0.149
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
