/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 декабря 2025 10:46:12
 * Version: 1.0.124
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

