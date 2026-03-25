/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 марта 2026 10:12:55
 * Version: 1.0.216
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
