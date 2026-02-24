/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 февраля 2026 13:20:55
 * Version: 1.0.187
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
