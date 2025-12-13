/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 декабря 2025 15:59:51
 * Version: 1.0.114
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
