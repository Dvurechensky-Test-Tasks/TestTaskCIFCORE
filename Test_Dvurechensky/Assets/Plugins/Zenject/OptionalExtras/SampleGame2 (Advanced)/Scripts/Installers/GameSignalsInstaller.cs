/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 сентября 2025 07:55:35
 * Version: 1.0.12
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
