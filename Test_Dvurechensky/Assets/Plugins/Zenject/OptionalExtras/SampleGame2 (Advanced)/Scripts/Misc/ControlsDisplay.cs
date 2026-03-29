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
    public class ControlsDisplay : MonoBehaviour
    {
        [SerializeField]
        float _leftPadding;

        [SerializeField]
        float _topPadding;

        [SerializeField]
        float _width;

        [SerializeField]
        float _height;

        public void OnGUI()
        {
            var bounds = new Rect(_leftPadding, _topPadding, _width, _height);
            GUI.Label(bounds, "CONTROLS:  WASD to move, Mouse to aim, Left Mouse to fire");
        }
    }
}

