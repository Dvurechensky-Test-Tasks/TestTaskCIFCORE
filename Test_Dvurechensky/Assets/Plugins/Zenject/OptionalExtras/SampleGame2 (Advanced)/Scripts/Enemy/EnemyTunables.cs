/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 марта 2026 10:10:08
 * Version: 1.0.219
 */

using System;

namespace Zenject.SpaceFighter
{
    // These values are given as parameters into dynamically created
    // EnemyFacade instances
    [Serializable]
    public class EnemyTunables
    {
        public float Accuracy;
        public float Speed;
    }
}
