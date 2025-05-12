/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 08:07:05
 * Version: 1.0.1
 */

using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Zenject.Internal
{
    public class DefaultSceneContractConfig : ScriptableObject
    {
        public const string ResourcePath = "ZenjectDefaultSceneContractConfig";

        public List<ContractInfo> DefaultContracts;

        [Serializable]
        public class ContractInfo
        {
            public string ContractName;
            public SceneAsset Scene;
        }
    }

}
