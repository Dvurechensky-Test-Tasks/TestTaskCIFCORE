/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 декабря 2025 13:05:34
 * Version: 1.0.109
 */

using System;
using System.Collections.Generic;

namespace Zenject
{
    [NoReflectionBaking]
    public class FactoryBindInfo
    {
        public FactoryBindInfo(Type factoryType)
        {
            FactoryType = factoryType;
            Arguments = new List<TypeValuePair>();
        }

        public Type FactoryType
        {
            get; private set;
        }

        public Func<DiContainer, IProvider> ProviderFunc
        {
            get; set;
        }

        public List<TypeValuePair> Arguments
        {
            get;
            set;
        }
    }
}
