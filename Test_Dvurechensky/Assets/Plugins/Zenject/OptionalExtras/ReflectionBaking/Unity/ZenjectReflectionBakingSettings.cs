/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 08:07:05
 * Version: 1.0.1
 */

using System.Collections.Generic;
using UnityEngine;

namespace Zenject.ReflectionBaking
{
    public class ZenjectReflectionBakingSettings : ScriptableObject
    {
        [SerializeField]
        bool _isEnabledInBuilds = true;

        [SerializeField]
        bool _isEnabledInEditor = false;

        [SerializeField]
        bool _allGeneratedAssemblies = true;

        [SerializeField]
        List<string> _includeAssemblies = null;

        [SerializeField]
        List<string> _excludeAssemblies = null;

        [SerializeField]
        List<string> _namespacePatterns = null;

        public List<string> NamespacePatterns
        {
            get { return _namespacePatterns; }
        }

        public List<string> IncludeAssemblies
        {
            get { return _includeAssemblies; }
        }

        public List<string> ExcludeAssemblies
        {
            get { return _excludeAssemblies; }
        }

        public bool IsEnabledInEditor
        {
            get { return _isEnabledInEditor; }
        }

        public bool IsEnabledInBuilds
        {
            get { return _isEnabledInBuilds; }
        }

        public bool AllGeneratedAssemblies
        {
            get { return _allGeneratedAssemblies; }
        }
    }
}
