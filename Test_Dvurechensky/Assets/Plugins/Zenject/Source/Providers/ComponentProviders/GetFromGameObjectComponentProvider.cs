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
using ModestTree;
using UnityEngine;

namespace Zenject
{
    [NoReflectionBaking]
    public class GetFromGameObjectComponentProvider : IProvider
    {
        readonly GameObject _gameObject;
        readonly Type _componentType;
        readonly bool _matchSingle;

        // if concreteType is null we use the contract type from inject context
        public GetFromGameObjectComponentProvider(
            Type componentType, GameObject gameObject, bool matchSingle)
        {
            _componentType = componentType;
            _matchSingle = matchSingle;
            _gameObject = gameObject;
        }

        public bool IsCached
        {
            get { return false; }
        }

        public bool TypeVariesBasedOnMemberType
        {
            get { return false; }
        }

        public Type GetInstanceType(InjectContext context)
        {
            return _componentType;
        }

        public void GetAllInstancesWithInjectSplit(
            InjectContext context, List<TypeValuePair> args, out Action injectAction, List<object> buffer)
        {
            Assert.IsNotNull(context);

            injectAction = null;

            if (_matchSingle)
            {
                var match = _gameObject.GetComponent(_componentType);

                Assert.IsNotNull(match, "Could not find component with type '{0}' on prefab '{1}'",
                _componentType, _gameObject.name);

                buffer.Add(match);
                return;
            }

            var allComponents = _gameObject.GetComponents(_componentType);

            Assert.That(allComponents.Length >= 1,
            "Expected to find at least one component with type '{0}' on prefab '{1}'",
            _componentType, _gameObject.name);

            buffer.AllocFreeAddRange(allComponents);
        }
    }
}

#endif

