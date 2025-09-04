/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 сентября 2025 08:07:37
 * Version: 1.0.13
 */

#if !ODIN_INSPECTOR

using UnityEditor;

namespace Zenject
{
    [NoReflectionBaking]
    public class RunnableContextEditor : ContextEditor
    {
        SerializedProperty _autoRun;

        public override void OnEnable()
        {
            base.OnEnable();

            _autoRun = serializedObject.FindProperty("_autoRun");
        }

        protected override void OnGui()
        {
            base.OnGui();

            EditorGUILayout.PropertyField(_autoRun);
        }
    }
}


#endif
