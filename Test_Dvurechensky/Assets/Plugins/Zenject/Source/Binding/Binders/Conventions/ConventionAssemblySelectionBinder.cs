/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 сентября 2025 10:08:30
 * Version: 1.0.14
 */

#if !(UNITY_WSA && ENABLE_DOTNET)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Zenject
{
    [NoReflectionBaking]
    public class ConventionAssemblySelectionBinder
    {
        public ConventionAssemblySelectionBinder(ConventionBindInfo bindInfo)
        {
            BindInfo = bindInfo;
        }

        protected ConventionBindInfo BindInfo
        {
            get;
            private set;
        }

        public void FromAllAssemblies()
        {
            // Do nothing
            // This is the default
        }

        public void FromAssemblyContaining<T>()
        {
            FromAssembliesContaining(typeof(T));
        }

        public void FromAssembliesContaining(params Type[] types)
        {
            FromAssembliesContaining((IEnumerable<Type>)types);
        }

        public void FromAssembliesContaining(IEnumerable<Type> types)
        {
            FromAssemblies(types.Select(t => t.Assembly).Distinct());
        }

        public void FromThisAssembly()
        {
            FromAssemblies(Assembly.GetCallingAssembly());
        }

        public void FromAssembly(Assembly assembly)
        {
            FromAssemblies(assembly);
        }

        public void FromAssemblies(params Assembly[] assemblies)
        {
            FromAssemblies((IEnumerable<Assembly>)assemblies);
        }

        public void FromAssemblies(IEnumerable<Assembly> assemblies)
        {
            BindInfo.AddAssemblyFilter(assembly => assemblies.Contains(assembly));
        }

        public void FromAssembliesWhere(Func<Assembly, bool> predicate)
        {
            BindInfo.AddAssemblyFilter(predicate);
        }
    }
}

#endif
