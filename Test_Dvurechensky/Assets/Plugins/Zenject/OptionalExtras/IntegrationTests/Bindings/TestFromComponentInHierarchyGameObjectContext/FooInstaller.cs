/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 ноября 2025 14:32:09
 * Version: 1.0.100
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
