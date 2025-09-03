/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 сентября 2025 07:55:35
 * Version: 1.0.12
 */


namespace Zenject
{
    // This is installed by default in ProjectContext, however, if you are using Zenject outside
    // of Unity then you might want to call this
    //
    // In this case though, you will have to manually call InitializableManager.Initialize,
    // DisposableManager.Dispose, TickableManager.Tick, etc. when appropriate for the environment
    // you are working in
    //
    // You might also want to use this installer in a ZenjectUnitTestFixture
    public class ZenjectManagersInstaller : Installer<ZenjectManagersInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind(typeof(TickableManager), typeof(InitializableManager), typeof(DisposableManager))
                .ToSelf().AsSingle().CopyIntoAllSubContainers();
        }
    }
}

