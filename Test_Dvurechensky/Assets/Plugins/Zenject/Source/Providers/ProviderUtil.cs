/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 сентября 2025 07:55:35
 * Version: 1.0.12
 */

using System;
using ModestTree;

namespace Zenject
{
    public static class ProviderUtil
    {
        public static Type GetTypeToInstantiate(Type contractType, Type concreteType)
        {
#if !(UNITY_WSA && ENABLE_DOTNET)
            // TODO: Is it possible to do this on WSA?

            if (concreteType.IsOpenGenericType())
            {
                return concreteType.MakeGenericType(contractType.GetGenericArguments());
            }
#endif

            Assert.DerivesFromOrEqual(concreteType, contractType);
            return concreteType;
        }
    }
}

