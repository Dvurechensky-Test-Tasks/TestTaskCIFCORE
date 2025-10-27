/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 октября 2025 15:37:11
 * Version: 1.0.67
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

