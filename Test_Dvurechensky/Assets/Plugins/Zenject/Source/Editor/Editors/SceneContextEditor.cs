/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 августа 2025 07:05:58
 * Version: 1.0.6
 */

#if !ODIN_INSPECTOR

using UnityEditor;

namespace Zenject
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(SceneContext))]
    [NoReflectionBaking]
    public class SceneContextEditor : RunnableContextEditor
    {
        SerializedProperty _contractNameProperty;
        SerializedProperty _parentNamesProperty;
        SerializedProperty _parentNewObjectsUnderSceneContextProperty;

        public override void OnEnable()
        {
            base.OnEnable();

            _contractNameProperty = serializedObject.FindProperty("_contractNames");
            _parentNamesProperty = serializedObject.FindProperty("_parentContractNames");
            _parentNewObjectsUnderSceneContextProperty = serializedObject.FindProperty("_parentNewObjectsUnderSceneContext");
        }

        protected override void OnGui()
        {
            base.OnGui();

            EditorGUILayout.PropertyField(_contractNameProperty, true);
            EditorGUILayout.PropertyField(_parentNamesProperty, true);
            EditorGUILayout.PropertyField(_parentNewObjectsUnderSceneContextProperty);
        }
    }
}


#endif
