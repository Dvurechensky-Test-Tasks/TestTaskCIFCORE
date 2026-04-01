/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 апреля 2026 13:04:02
 * Version: 1.0.223
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
