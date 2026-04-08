/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 апреля 2026 14:25:30
 * Version: 1.0.230
 */

using System;
using UnityEngine;

namespace Zenject.Asteroids
{
    public class AudioHandler : IInitializable, IDisposable
    {
        readonly SignalBus _signalBus;
        readonly Settings _settings;
        readonly AudioSource _audioSource;

        public AudioHandler(
            AudioSource audioSource,
            Settings settings,
            SignalBus signalBus)
        {
            _signalBus = signalBus;
            _settings = settings;
            _audioSource = audioSource;
        }

        public void Initialize()
        {
            _signalBus.Subscribe<ShipCrashedSignal>(OnShipCrashed);
        }

        public void Dispose()
        {
            _signalBus.Unsubscribe<ShipCrashedSignal>(OnShipCrashed);
        }

        void OnShipCrashed()
        {
            _audioSource.PlayOneShot(_settings.CrashSound);
        }

        [Serializable]
        public class Settings
        {
            public AudioClip CrashSound;
        }
    }
}
