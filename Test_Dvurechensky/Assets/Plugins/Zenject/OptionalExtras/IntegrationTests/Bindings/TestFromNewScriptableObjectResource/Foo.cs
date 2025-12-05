/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 декабря 2025 14:55:01
 * Version: 1.0.106
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
