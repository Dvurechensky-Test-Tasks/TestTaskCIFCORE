/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 марта 2026 10:10:08
 * Version: 1.0.219
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
