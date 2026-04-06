/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 апреля 2026 12:46:40
 * Version: 1.0.228
 */

using UnityEngine;

#pragma warning disable 649

namespace Zenject.Tests.Bindings.FromComponentInHierarchyGameObjectContext
{
    public class FooInstaller : MonoInstaller
    {
        [SerializeField]
        Foo _foo;

        public override void InstallBindings()
        {
            Container.Bind<Foo>().FromInstance(_foo).AsSingle();
            Container.Bind<Gorp>().FromComponentInHierarchy().AsSingle();
        }
    }
}
