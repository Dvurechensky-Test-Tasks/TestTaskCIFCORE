/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 августа 2025 07:38:17
 * Version: 1.0.9
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
