/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 апреля 2026 14:13:56
 * Version: 1.0.234
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
