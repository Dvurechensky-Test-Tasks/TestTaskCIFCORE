/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 сентября 2025 11:44:34
 * Version: 1.0.15
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
