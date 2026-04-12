/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 апреля 2026 14:13:56
 * Version: 1.0.234
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

