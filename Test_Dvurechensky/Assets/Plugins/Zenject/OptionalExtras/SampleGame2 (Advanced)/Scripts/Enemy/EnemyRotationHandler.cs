/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 августа 2025 08:33:25
 * Version: 1.0.8
 */

using System;
using UnityEngine;

namespace Zenject.SpaceFighter
{
    // Responsibilities:
    // - Interpolate rotation of enemy towards the current desired
    // direction
    public class EnemyRotationHandler : IFixedTickable
    {
        readonly Settings _settings;
        readonly EnemyView _view;

        public EnemyRotationHandler(
            EnemyView view,
            Settings settings)
        {
            _settings = settings;
            _view = view;
        }

        public Vector2 DesiredLookDir
        {
            get; set;
        }

        public void FixedTick()
        {
            var lookDir = _view.LookDir;

            var error = Vector3.Angle(lookDir, DesiredLookDir);

            if (Vector3.Cross(lookDir, DesiredLookDir).z < 0)
            {
                error *= -1;
            }

            _view.AddTorque(error * _settings.TurnSpeed);
        }

        [Serializable]
        public class Settings
        {
            public float TurnSpeed;
        }
    }
}
