/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 сентября 2025 07:55:35
 * Version: 1.0.12
 */

#if !ODIN_INSPECTOR

namespace Zenject
{
    [NoReflectionBaking]
    public class ContextEditor : UnityInspectorListEditor
    {
        protected override string[] PropertyNames
        {
            get
            {
                return new string[]
                {
                    "_scriptableObjectInstallers",
                    "_monoInstallers",
                    "_installerPrefabs",
                };
            }
        }

        protected override string[] PropertyDisplayNames
        {
            get
            {
                return new string[]
                {
                    "Scriptable Object Installers",
                    "Mono Installers",
                    "Prefab Installers",
                };
            }
        }

        protected override string[] PropertyDescriptions
        {
            get
            {
                return new string[]
                {
                    "Drag any assets in your Project that implement ScriptableObjectInstaller here",
                    "Drag any MonoInstallers that you have added to your Scene Hierarchy here.",
                    "Drag any prefabs that contain a MonoInstaller on them here",
                };
            }
        }
    }
}

#endif
