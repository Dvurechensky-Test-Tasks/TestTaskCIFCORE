/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 декабря 2025 13:32:01
 * Version: 1.0.110
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
