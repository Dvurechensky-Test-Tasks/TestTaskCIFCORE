/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 августа 2025 07:05:58
 * Version: 1.0.6
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
