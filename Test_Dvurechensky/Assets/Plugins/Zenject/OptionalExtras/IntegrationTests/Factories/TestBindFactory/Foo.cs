/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 февраля 2026 09:41:14
 * Version: 1.0.190
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
