/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 ноября 2025 06:50:27
 * Version: 1.0.84
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
