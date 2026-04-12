/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 апреля 2026 14:13:56
 * Version: 1.0.234
 */

using UnityEngine;

namespace Zenject.Tests.Factories.BindFactoryOne
{
    public interface IFoo
    {
        string Value
        {
            get;
        }
    }

    public class IFooFactory : PlaceholderFactory<string, IFoo>
    {
    }

    public class Foo : MonoBehaviour, IFoo
    {
        [Inject]
        public void Init(string value)
        {
            Value = value;
        }

        public string Value
        {
            get;
            private set;
        }

        public class Factory : PlaceholderFactory<string, Foo>
        {
        }
    }
}
