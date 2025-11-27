/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 ноября 2025 06:50:27
 * Version: 1.0.98
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
