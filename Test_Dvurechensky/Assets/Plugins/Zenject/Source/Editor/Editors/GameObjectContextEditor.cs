/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 апреля 2026 12:57:33
 * Version: 1.0.226
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
