/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 февраля 2026 11:48:56
 * Version: 1.0.176
 */

using UnityEngine;

namespace Zenject.Tests.Bindings.FromNewScriptableObjectResource
{
    public interface IFoo
    {
    }

    //[CreateAssetMenu(fileName = "Foo", menuName = "Test/Foo")]
    public class Foo : ScriptableObject, IFoo
    {
        public static int InstanceCount
        {
            get;
            set;
        }

        public bool WasInjected
        {
            get;
            private set;
        }

        [Inject]
        public void Construct()
        {
            WasInjected = true;
            InstanceCount++;
        }
    }
}
