/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 19 ноября 2025 08:14:27
 * Version: 1.0.90
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
