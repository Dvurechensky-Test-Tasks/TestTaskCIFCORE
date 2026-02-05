/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 февраля 2026 07:40:37
 * Version: 1.0.168
 */

using ModestTree;
using UnityEngine;

#pragma warning disable 649

namespace Zenject.Tests.Bindings.DiContainerMethods
{
    //[CreateAssetMenu(fileName = "Gorp2", menuName = "Test/Gorp2")]
    public class Gorp2 : ScriptableObject
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
