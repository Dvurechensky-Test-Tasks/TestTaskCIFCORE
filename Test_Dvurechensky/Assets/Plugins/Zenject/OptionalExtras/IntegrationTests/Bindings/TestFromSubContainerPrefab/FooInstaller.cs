/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 ноября 2025 10:15:56
 * Version: 1.0.93
 */

using UnityEngine;

#pragma warning disable 649

namespace Zenject.Tests.Bindings.FromSubContainerPrefab
{
    public class FooInstaller : MonoInstaller
    {
        [SerializeField]
        Bar _bar;

        public override void InstallBindings()
        {
            Container.BindInstance(_bar);
            Container.Bind<Gorp>().WithId("gorp").AsSingle();
        }
    }
}
