/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 08:07:05
 * Version: 1.0.1
 */

using UnityEngine;

#pragma warning disable 649

namespace Zenject.Asteroids
{
    public class TilingBackground : MonoBehaviour
    {
        [SerializeField]
        float _speed;

        Vector2 _offset;
        Renderer _renderer;

        void Awake()
        {
            _renderer = GetComponent<Renderer>();
        }

        void Update()
        {
            _offset.y += _speed * Time.deltaTime;
            _renderer.material.mainTextureOffset = _offset;
        }
    }
}
