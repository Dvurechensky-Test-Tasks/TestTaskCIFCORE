/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 октября 2025 15:37:11
 * Version: 1.0.67
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
