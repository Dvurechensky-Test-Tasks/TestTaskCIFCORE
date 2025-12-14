/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 декабря 2025 14:32:37
 * Version: 1.0.115
 */

#if UNITY_EDITOR

using System;
using UnityEditor;
using UnityEngine;

namespace Zenject
{
    public class SceneTestFixtureSceneReference : ScriptableObject
    {
        public SceneAsset Scene;
    }
}

#endif
