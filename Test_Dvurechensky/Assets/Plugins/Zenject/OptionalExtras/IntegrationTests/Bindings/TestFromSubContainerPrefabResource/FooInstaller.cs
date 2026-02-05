/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 февраля 2026 07:40:37
 * Version: 1.0.168
 */

using UnityEngine;

#pragma warning disable 649

namespace Zenject.Tests.Bindings.FromSubContainerPrefabResource
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
