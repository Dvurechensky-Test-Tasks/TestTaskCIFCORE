/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 января 2026 15:45:21
 * Version: 1.0.137
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
