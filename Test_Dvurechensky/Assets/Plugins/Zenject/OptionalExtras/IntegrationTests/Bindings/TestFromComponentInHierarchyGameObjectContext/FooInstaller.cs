/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 декабря 2025 15:59:51
 * Version: 1.0.114
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
