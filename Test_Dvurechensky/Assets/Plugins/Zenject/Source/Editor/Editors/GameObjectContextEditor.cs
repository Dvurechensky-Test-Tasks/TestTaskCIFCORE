/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 марта 2026 11:11:52
 * Version: 1.0.220
 */

#if !ODIN_INSPECTOR

using UnityEditor;

namespace Zenject
{
    [CustomEditor(typeof(GameObjectContext))]
    [NoReflectionBaking]
    public class GameObjectContextEditor : RunnableContextEditor
    {
        SerializedProperty _kernel;

        public override void OnEnable()
        {
            base.OnEnable();

            _kernel = serializedObject.FindProperty("_kernel");
        }

        protected override void OnGui()
        {
            base.OnGui();

            EditorGUILayout.PropertyField(_kernel);
        }
    }
}

#endif
