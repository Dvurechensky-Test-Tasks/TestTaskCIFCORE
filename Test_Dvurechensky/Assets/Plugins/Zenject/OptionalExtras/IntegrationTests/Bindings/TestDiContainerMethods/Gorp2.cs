/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 января 2026 17:28:28
 * Version: 1.0.147
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
