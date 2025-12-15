/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 декабря 2025 06:50:28
 * Version: 1.0.116
 */

using UnityEngine;

namespace Zenject.Tests.Factories.BindFactory
{
    public interface IFoo
    {
    }

    public class IFooFactory : PlaceholderFactory<IFoo>
    {
    }

    public class Foo : MonoBehaviour, IFoo
    {
        public class Factory : PlaceholderFactory<Foo>
        {
        }
    }
}
