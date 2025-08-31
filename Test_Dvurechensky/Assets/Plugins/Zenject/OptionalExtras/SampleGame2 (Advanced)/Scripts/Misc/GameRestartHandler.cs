/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 августа 2025 07:38:17
 * Version: 1.0.9
 */

using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Zenject.SpaceFighter
{
    public class GameRestartHandler : IInitializable, IDisposable, ITickable
    {
        readonly SignalBus _signalBus;
        readonly Settings _settings;

        bool _isDelaying;
        float _delayStartTime;

        public GameRestartHandler(
            Settings settings,
            SignalBus signalBus)
        {
            _signalBus = signalBus;
            _settings = settings;
        }

        public void Initialize()
        {
            _signalBus.Subscribe<PlayerDiedSignal>(OnPlayerDied);
        }

        public void Dispose()
        {
            _signalBus.Unsubscribe<PlayerDiedSignal>(OnPlayerDied);
        }

        public void Tick()
        {
            if (_isDelaying)
            {
                if (Time.realtimeSinceStartup - _delayStartTime > _settings.RestartDelay)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }
            }
        }

        void OnPlayerDied()
        {
            // Wait a bit before restarting the scene
            _delayStartTime = Time.realtimeSinceStartup;
            _isDelaying = true;
        }

        [Serializable]
        public class Settings
        {
            public float RestartDelay;
        }
    }
}
