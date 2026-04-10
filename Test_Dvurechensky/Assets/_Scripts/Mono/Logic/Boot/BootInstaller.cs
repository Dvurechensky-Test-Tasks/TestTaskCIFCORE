/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 апреля 2026 12:30:12
 * Version: 1.0.232
 */

using Zenject;

/// <summary>
/// РљРѕРЅС‚РµР№РЅРµСЂ СЂРµРіРёСЃС‚СЂР°С†РёРё РѕР±СЉРµРєС‚РѕРІ
/// </summary>
public class BootInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<INetDataService>().To<NetDataService>().AsSingle();
        Container.Bind<INetForecastService>().To<NetForecastService>().AsSingle();
        Container.Bind<INetFactsService>().To<NetFactsService>().AsSingle();
        
        Container.Bind<NetService>().AsTransient();
        Container.Bind<AddressableService>().AsTransient();
        
        Container.Bind<ObjectsPools>().AsCached();
    }
}
