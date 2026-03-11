/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 марта 2026 06:50:29
 * Version: 1.0.202
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
