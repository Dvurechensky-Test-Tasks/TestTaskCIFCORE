/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 октября 2025 10:57:33
 * Version: 1.0.51
 */

#if !NOT_UNITY3D

namespace Zenject
{
    [NoReflectionBaking]
    public class NameTransformScopeConcreteIdArgConditionCopyNonLazyBinder : TransformScopeConcreteIdArgConditionCopyNonLazyBinder
    {
        public NameTransformScopeConcreteIdArgConditionCopyNonLazyBinder(
            BindInfo bindInfo,
            GameObjectCreationParameters gameObjectInfo)
            : base(bindInfo, gameObjectInfo)
        {
        }

        public TransformScopeConcreteIdArgConditionCopyNonLazyBinder WithGameObjectName(string gameObjectName)
        {
            GameObjectInfo.Name = gameObjectName;
            return this;
        }
    }
}

#endif
