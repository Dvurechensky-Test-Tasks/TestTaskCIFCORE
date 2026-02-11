/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 февраля 2026 09:12:46
 * Version: 1.0.174
 */

using ModestTree;
using UnityEngine;

#pragma warning disable 649

namespace Zenject.Tests.Bindings.FromPrefabResource
{
    public class Gorp : MonoBehaviour
    {
        [Inject]
        string _arg;

        [Inject]
        public void Initialize()
        {
            Log.Trace("Received arg '{0}' in Gorp", _arg);
        }
    }
}
