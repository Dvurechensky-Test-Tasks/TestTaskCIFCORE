/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 ноября 2025 14:36:10
 * Version: 1.0.101
 */

namespace Zenject.SpaceFighter
{
    public class EnemyInstaller : Installer<EnemyInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<EnemyTunables>().AsSingle();

            Container.BindInterfacesAndSelfTo<EnemyStateManager>().AsSingle();

            Container.Bind<EnemyStateIdle>().AsSingle();
            Container.Bind<EnemyStateAttack>().AsSingle();
            Container.Bind<EnemyStateFollow>().AsSingle();

            Container.BindInterfacesAndSelfTo<EnemyDeathHandler>().AsSingle();
            Container.BindInterfacesAndSelfTo<EnemyRotationHandler>().AsSingle();
        }
    }
}
