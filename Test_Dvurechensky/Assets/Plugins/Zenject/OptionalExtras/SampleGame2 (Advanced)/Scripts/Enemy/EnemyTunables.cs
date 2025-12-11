/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 декабря 2025 14:02:32
 * Version: 1.0.112
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
