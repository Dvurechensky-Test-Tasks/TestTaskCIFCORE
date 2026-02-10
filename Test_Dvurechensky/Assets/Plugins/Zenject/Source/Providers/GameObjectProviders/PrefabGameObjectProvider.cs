/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 февраля 2026 10:31:59
 * Version: 1.0.173
 */

#if !NOT_UNITY3D

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject
{
    [NoReflectionBaking]
    public class PrefabGameObjectProvider : IProvider
    {
        readonly IPrefabInstantiator _prefabCreator;

        public PrefabGameObjectProvider(
            IPrefabInstantiator prefabCreator)
        {
            _prefabCreator = prefabCreator;
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
            return typeof(GameObject);
        }

        public void GetAllInstancesWithInjectSplit(
            InjectContext context, List<TypeValuePair> args, out Action injectAction, List<object> buffer)
        {
            var instance = _prefabCreator.Instantiate(context, args, out injectAction);

            buffer.Add(instance);
        }
    }
}

#endif
