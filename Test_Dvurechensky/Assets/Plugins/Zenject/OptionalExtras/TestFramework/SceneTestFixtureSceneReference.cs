/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 марта 2026 09:54:23
 * Version: 1.0.199
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
