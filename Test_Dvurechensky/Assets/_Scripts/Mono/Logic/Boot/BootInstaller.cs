/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 августа 2025 06:50:28
 * Version: 1.0.7
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
