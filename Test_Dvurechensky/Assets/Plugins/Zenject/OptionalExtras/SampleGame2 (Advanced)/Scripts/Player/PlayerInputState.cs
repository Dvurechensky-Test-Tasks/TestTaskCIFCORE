/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 08:07:05
 * Version: 1.0.1
 */

namespace Zenject.SpaceFighter
{
    public class PlayerInputState
    {
        public bool IsMovingLeft
        {
            get;
            set;
        }

        public bool IsMovingRight
        {
            get;
            set;
        }

        public bool IsMovingUp
        {
            get;
            set;
        }

        public bool IsMovingDown
        {
            get;
            set;
        }

        public bool IsFiring
        {
            get;
            set;
        }
    }
}
