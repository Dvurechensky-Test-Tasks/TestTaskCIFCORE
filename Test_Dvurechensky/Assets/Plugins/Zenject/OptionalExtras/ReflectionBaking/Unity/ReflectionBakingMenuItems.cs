/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 февраля 2026 15:54:06
 * Version: 1.0.191
 */

#if !NOT_UNITY3D

using System.IO;
using UnityEditor;
using UnityEngine;
using Zenject.Internal;

namespace Zenject.ReflectionBaking
{
    public static class ReflectionBakingMenuItems
    {
        [MenuItem("Assets/Create/Zenject/Reflection Baking Settings", false, 100)]
        public static void CreateReflectionBakingSettings()
        {
            var folderPath = ZenUnityEditorUtil.GetCurrentDirectoryAssetPathFromSelection();

            var config = ScriptableObject.CreateInstance<ZenjectReflectionBakingSettings>();

            ZenUnityEditorUtil.SaveScriptableObjectAsset(
                Path.Combine(folderPath, "ZenjectReflectionBakingSettings.asset"), config);
        }
    }
}
#endif
