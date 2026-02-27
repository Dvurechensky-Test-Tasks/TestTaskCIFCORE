/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 февраля 2026 09:41:14
 * Version: 1.0.190
 */

#if !NOT_UNITY3D

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject
{
    public interface IPrefabInstantiator
    {
        Type ArgumentTarget
        {
            get;
        }

        List<TypeValuePair> ExtraArguments
        {
            get;
        }

        GameObjectCreationParameters GameObjectCreationParameters
        {
            get;
        }

        GameObject Instantiate(InjectContext context, List<TypeValuePair> args, out Action injectAction);

        UnityEngine.Object GetPrefab(InjectContext context);
    }
}

#endif
