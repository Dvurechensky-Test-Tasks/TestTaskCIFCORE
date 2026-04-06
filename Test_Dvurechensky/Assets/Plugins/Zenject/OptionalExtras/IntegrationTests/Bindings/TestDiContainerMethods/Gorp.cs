/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 апреля 2026 12:46:40
 * Version: 1.0.228
 */

using ModestTree;
using UnityEngine;

#pragma warning disable 649

namespace Zenject.Tests.Bindings.DiContainerMethods
{
    public class Gorp : MonoBehaviour
    {
        [Inject]
        string _arg;

        public string Arg
        {
            get { return _arg; }
        }

        [Inject]
        public void Initialize()
        {
            Log.Trace("Received arg '{0}' in Gorp", _arg);
        }
    }
}
