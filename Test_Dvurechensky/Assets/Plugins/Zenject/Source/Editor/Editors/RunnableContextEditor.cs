/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 апреля 2026 12:30:12
 * Version: 1.0.232
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
