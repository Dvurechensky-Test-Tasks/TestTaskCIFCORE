/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 08:07:05
 * Version: 1.0.1
 */

using UnityEngine;

namespace Zenject.SpaceFighter
{
    // Include this just to ensure BindSignal with an object mapping works
    public class PlayerDiedSignalObserver
    {
        public void OnPlayerDied()
        {
            Debug.Log("Fired PlayerDiedSignal");
        }
    }

    public class GameSignalsInstaller : Installer<GameSignalsInstaller>
    {
        public override void InstallBindings()
        {
            SignalBusInstaller.Install(Container);

            Container.DeclareSignal<EnemyKilledSignal>();
            Container.DeclareSignal<PlayerDiedSignal>();

            // Include these just to ensure BindSignal works
            Container.BindSignal<PlayerDiedSignal>().ToMethod<PlayerDiedSignalObserver>(x => x.OnPlayerDied).FromNew();
            Container.BindSignal<EnemyKilledSignal>().ToMethod(() => Debug.Log("Fired EnemyKilledSignal"));
        }
    }

}
