/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 ноября 2025 09:06:52
 * Version: 1.0.99
 */

#if !(UNITY_WSA && ENABLE_DOTNET)

namespace Zenject
{
    [NoReflectionBaking]
    public class ConventionSelectTypesBinder
    {
        readonly ConventionBindInfo _bindInfo;

        public ConventionSelectTypesBinder(ConventionBindInfo bindInfo)
        {
            _bindInfo = bindInfo;
        }

        ConventionFilterTypesBinder CreateNextBinder()
        {
            return new ConventionFilterTypesBinder(_bindInfo);
        }

        public ConventionFilterTypesBinder AllTypes()
        {
            // Do nothing (this is the default)
            return CreateNextBinder();
        }

        public ConventionFilterTypesBinder AllClasses()
        {
            _bindInfo.AddTypeFilter(t => t.IsClass);
            return CreateNextBinder();
        }

        public ConventionFilterTypesBinder AllNonAbstractClasses()
        {
            _bindInfo.AddTypeFilter(t => t.IsClass && !t.IsAbstract);
            return CreateNextBinder();
        }

        public ConventionFilterTypesBinder AllAbstractClasses()
        {
            _bindInfo.AddTypeFilter(t => t.IsClass && t.IsAbstract);
            return CreateNextBinder();
        }

        public ConventionFilterTypesBinder AllInterfaces()
        {
            _bindInfo.AddTypeFilter(t => t.IsInterface);
            return CreateNextBinder();
        }
    }
}

#endif
