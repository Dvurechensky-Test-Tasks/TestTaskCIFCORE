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
    [CustomEditor(typeof(ProjectContext))]
    [NoReflectionBaking]
    public class ProjectContextEditor : ContextEditor
    {
        SerializedProperty _settingsProperty;
        SerializedProperty _editorReflectionBakingCoverageModeProperty;
        SerializedProperty _buildsReflectionBakingCoverageModeProperty;
        SerializedProperty _parentNewObjectsUnderContextProperty;

        public override void OnEnable()
        {
            base.OnEnable();

            _settingsProperty = serializedObject.FindProperty("_settings");
            _editorReflectionBakingCoverageModeProperty = serializedObject.FindProperty("_editorReflectionBakingCoverageMode");
            _buildsReflectionBakingCoverageModeProperty = serializedObject.FindProperty("_buildsReflectionBakingCoverageMode");
            _parentNewObjectsUnderContextProperty = serializedObject.FindProperty("_parentNewObjectsUnderContext");
        }

        protected override void OnGui()
        {
            base.OnGui();

            EditorGUILayout.PropertyField(_settingsProperty, true);
            EditorGUILayout.PropertyField(_editorReflectionBakingCoverageModeProperty, true);
            EditorGUILayout.PropertyField(_buildsReflectionBakingCoverageModeProperty, true);
            EditorGUILayout.PropertyField(_parentNewObjectsUnderContextProperty);
        }
    }
}

#endif
