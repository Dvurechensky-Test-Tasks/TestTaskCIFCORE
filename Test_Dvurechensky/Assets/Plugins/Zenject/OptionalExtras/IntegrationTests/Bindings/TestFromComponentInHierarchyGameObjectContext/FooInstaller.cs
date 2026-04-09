/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 апреля 2026 10:55:50
 * Version: 1.0.231
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
