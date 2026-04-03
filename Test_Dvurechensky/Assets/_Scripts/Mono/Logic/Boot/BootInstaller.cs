/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 апреля 2026 11:30:59
 * Version: 1.0.225
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
