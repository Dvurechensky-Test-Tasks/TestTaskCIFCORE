/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 января 2026 16:22:52
 * Version: 1.0.133
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
