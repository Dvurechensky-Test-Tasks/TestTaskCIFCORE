/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 февраля 2026 15:54:06
 * Version: 1.0.191
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
