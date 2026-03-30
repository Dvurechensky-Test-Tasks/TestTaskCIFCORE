/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 марта 2026 12:19:05
 * Version: 1.0.221
 */

#if !(UNITY_WSA && ENABLE_DOTNET)

using System;

namespace Zenject.Tests.Convention
{
    public class ConventionTestAttribute : Attribute
    {
        public ConventionTestAttribute(int num)
        {
            Num = num;
        }

        public int Num
        {
            get;
            private set;
        }
    }

    public interface IFoo
    {
    }

    public class Foo1 : IFoo
    {
    }

    [ConventionTest(0)]
    public class Foo2 : IFoo
    {
    }

    [ConventionTest(1)]
    public class Foo3 : IFoo
    {
    }
}

#endif
