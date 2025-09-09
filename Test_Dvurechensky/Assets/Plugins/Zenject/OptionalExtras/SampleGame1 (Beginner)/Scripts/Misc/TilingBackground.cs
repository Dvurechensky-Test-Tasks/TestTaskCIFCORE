/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 сентября 2025 11:10:33
 * Version: 1.0.18
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
