/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 марта 2026 11:11:52
 * Version: 1.0.220
 */

using UnityEngine;

#pragma warning disable 649

namespace Zenject.SpaceFighter
{
    public class Explosion : MonoBehaviour, IPoolable<IMemoryPool>
    {
        [SerializeField]
        float _lifeTime;

        [SerializeField]
        ParticleSystem _particleSystem;

        float _startTime;

        IMemoryPool _pool;

        public void Update()
        {
            if (Time.realtimeSinceStartup - _startTime > _lifeTime)
            {
                _pool.Despawn(this);
            }
        }

        public void OnDespawned()
        {
        }

        public void OnSpawned(IMemoryPool pool)
        {
            _particleSystem.Clear();
            _particleSystem.Play();

            _startTime = Time.realtimeSinceStartup;
            _pool = pool;
        }

        public class Factory : PlaceholderFactory<Explosion>
        {
        }
    }
}

