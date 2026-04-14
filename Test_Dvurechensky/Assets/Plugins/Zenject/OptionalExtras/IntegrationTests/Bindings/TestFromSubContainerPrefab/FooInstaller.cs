/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 апреля 2026 12:23:01
 * Version: 1.0.236
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
