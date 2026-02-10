/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 февраля 2026 10:31:59
 * Version: 1.0.173
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
