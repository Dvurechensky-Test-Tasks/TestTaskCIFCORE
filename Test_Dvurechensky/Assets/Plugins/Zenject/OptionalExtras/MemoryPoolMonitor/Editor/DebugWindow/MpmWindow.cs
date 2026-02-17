/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 февраля 2026 09:24:49
 * Version: 1.0.180
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
