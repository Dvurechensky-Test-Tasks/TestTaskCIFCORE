/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 января 2026 07:54:44
 * Version: 1.0.155
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
