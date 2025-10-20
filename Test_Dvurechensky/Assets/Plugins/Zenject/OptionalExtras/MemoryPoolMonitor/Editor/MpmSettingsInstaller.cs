/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 октября 2025 11:17:32
 * Version: 1.0.59
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
