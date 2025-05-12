/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 08:07:05
 * Version: 1.0.1
 */

#if !NOT_UNITY3D

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject
{
    [NoReflectionBaking]
    public class AddToNewGameObjectComponentProvider : AddToGameObjectComponentProviderBase
    {
        readonly GameObjectCreationParameters _gameObjectBindInfo;

        public AddToNewGameObjectComponentProvider(
            DiContainer container, Type componentType,
            IEnumerable<TypeValuePair> extraArguments, GameObjectCreationParameters gameObjectBindInfo,
            object concreteIdentifier,
            Action<InjectContext, object> instantiateCallback)
            : base(container, componentType, extraArguments, concreteIdentifier, instantiateCallback)
        {
            _gameObjectBindInfo = gameObjectBindInfo;
        }

        protected override bool ShouldToggleActive
        {
            get { return true; }
        }

        protected override GameObject GetGameObject(InjectContext context)
        {
            if (_gameObjectBindInfo.Name == null)
            {
                _gameObjectBindInfo.Name = ComponentType.Name;
            }

            return Container.CreateEmptyGameObject(_gameObjectBindInfo, context);
        }
    }
}

#endif
