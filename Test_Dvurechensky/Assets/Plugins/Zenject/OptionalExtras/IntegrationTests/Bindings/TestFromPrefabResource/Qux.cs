/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 февраля 2026 09:41:14
 * Version: 1.0.190
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
