/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 февраля 2026 13:30:34
 * Version: 1.0.185
 */

using UnityEngine;

namespace Zenject.SpaceFighter
{
    public class PlayerInputHandler : ITickable
    {
        readonly PlayerInputState _inputState;

        public PlayerInputHandler(PlayerInputState inputState)
        {
            _inputState = inputState;
        }

        public void Tick()
        {
            _inputState.IsMovingLeft = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
            _inputState.IsMovingRight = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);
            _inputState.IsMovingUp = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
            _inputState.IsMovingDown = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S);

            _inputState.IsFiring = Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0);
        }
    }
}
