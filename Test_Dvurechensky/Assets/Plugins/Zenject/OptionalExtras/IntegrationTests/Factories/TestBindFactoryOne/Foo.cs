/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 декабря 2025 14:32:37
 * Version: 1.0.115
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
