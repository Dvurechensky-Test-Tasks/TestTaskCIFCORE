/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 октября 2025 14:55:51
 * Version: 1.0.61
 */

using System.Collections.Generic;

namespace Zenject.SpaceFighter
{
    public class EnemyRegistry
    {
        readonly List<EnemyFacade> _enemies = new List<EnemyFacade>();

        public IEnumerable<EnemyFacade> Enemies
        {
            get { return _enemies; }
        }

        public void AddEnemy(EnemyFacade enemy)
        {
            _enemies.Add(enemy);
        }

        public void RemoveEnemy(EnemyFacade enemy)
        {
            _enemies.Remove(enemy);
        }
    }
}
