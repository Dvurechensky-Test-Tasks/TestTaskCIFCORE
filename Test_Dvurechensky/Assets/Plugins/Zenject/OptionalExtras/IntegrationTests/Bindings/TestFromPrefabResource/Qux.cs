/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 сентября 2025 17:13:59
 * Version: 1.0.32
 */

using ModestTree;
using UnityEngine;

#pragma warning disable 649

namespace Zenject.Tests.Bindings.FromPrefabResource
{
    public class Qux : MonoBehaviour
    {
        [Inject]
        int _arg;

        [Inject]
        public void Initialize()
        {
            Log.Trace("Received arg '{0}' in Qux", _arg);
        }
    }
}
