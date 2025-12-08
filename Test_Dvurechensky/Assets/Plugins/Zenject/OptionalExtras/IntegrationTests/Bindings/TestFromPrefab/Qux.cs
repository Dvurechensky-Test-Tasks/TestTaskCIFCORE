/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 декабря 2025 13:05:34
 * Version: 1.0.109
 */

using ModestTree;
using UnityEngine;

#pragma warning disable 649

namespace Zenject.Tests.Bindings.FromPrefab
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
