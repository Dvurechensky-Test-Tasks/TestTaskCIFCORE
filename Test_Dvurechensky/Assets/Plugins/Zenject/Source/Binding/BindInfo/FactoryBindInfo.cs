/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 апреля 2026 12:46:40
 * Version: 1.0.228
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
