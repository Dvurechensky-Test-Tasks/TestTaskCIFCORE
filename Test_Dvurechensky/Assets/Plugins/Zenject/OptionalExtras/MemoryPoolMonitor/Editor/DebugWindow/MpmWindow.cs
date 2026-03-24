/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 марта 2026 08:52:35
 * Version: 1.0.215
 */

using System;
using ModestTree;
using UnityEngine;
using UnityEditor;
using Zenject;

namespace Zenject.MemoryPoolMonitor
{
    public class MpmWindow : ZenjectEditorWindow
    {
        [MenuItem("Window/Zenject Pool Monitor")]
        public static MpmWindow GetOrCreateWindow()
        {
            var window = EditorWindow.GetWindow<MpmWindow>();
            window.titleContent = new GUIContent("Pool Monitor");
            return window;
        }

        public override void InstallBindings()
        {
            MpmSettingsInstaller.InstallFromResource(Container);

            Container.BindInstance(this);
            Container.BindInterfacesTo<MpmView>().AsSingle();
        }
    }
}
