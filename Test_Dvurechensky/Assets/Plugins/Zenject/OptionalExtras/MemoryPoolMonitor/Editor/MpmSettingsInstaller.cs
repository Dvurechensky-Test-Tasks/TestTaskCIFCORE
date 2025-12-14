/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 декабря 2025 14:32:37
 * Version: 1.0.115
 */

using UnityEngine;
using UnityEditor;
using Zenject;

namespace Zenject.MemoryPoolMonitor
{
    [CreateAssetMenu(fileName = "MpmSettingsInstaller", menuName = "Installers/MpmSettingsInstaller")]
    public class MpmSettingsInstaller : ScriptableObjectInstaller<MpmSettingsInstaller>
    {
        public MpmView.Settings MpmView;
        public MpmView.Settings MpmViewDark;

        public override void InstallBindings()
        {
            Container.BindInstance(EditorGUIUtility.isProSkin ? MpmViewDark : MpmView);
        }
    }
}
