/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 августа 2025 08:33:25
 * Version: 1.0.8
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
