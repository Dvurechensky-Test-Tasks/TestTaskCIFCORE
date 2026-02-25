/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 февраля 2026 13:59:57
 * Version: 1.0.188
 */

using UnityEngine;

namespace Zenject.Tests.Bindings.FromNewScriptableObjectResource
{
    //[CreateAssetMenu(fileName = "Bob", menuName = "Test/Bob")]
    public class Bob : ScriptableObject
    {
        public string Arg
        {
            get;
            private set;
        }

        [Inject]
        public void Construct(string arg)
        {
            Arg = arg;
        }
    }
}

