/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 сентября 2025 11:44:34
 * Version: 1.0.15
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

