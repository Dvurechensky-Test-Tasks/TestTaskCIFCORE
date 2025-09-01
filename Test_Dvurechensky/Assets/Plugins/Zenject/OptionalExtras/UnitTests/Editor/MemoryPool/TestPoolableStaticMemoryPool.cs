/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 сентября 2025 11:04:53
 * Version: 1.0.10
 */

using System;
using NUnit.Framework;
using Assert = ModestTree.Assert;

namespace Zenject.Tests
{
    [TestFixture]
    public class TestPoolableStaticMemoryPool : ZenjectUnitTestFixture
    {
        [Test]
        public void RunTest()
        {
            var pool = Foo.Pool;

            pool.Clear();

            Assert.IsEqual(pool.NumActive, 0);
            Assert.IsEqual(pool.NumInactive, 0);
            Assert.IsEqual(pool.NumTotal, 0);

            var foo = pool.Spawn("asdf");

            Assert.IsEqual(pool.NumActive, 1);
            Assert.IsEqual(pool.NumInactive, 0);
            Assert.IsEqual(pool.NumTotal, 1);
            Assert.IsEqual(foo.Data, "asdf");

            foo.Dispose();

            Assert.IsEqual(pool.NumActive, 0);
            Assert.IsEqual(pool.NumInactive, 1);
            Assert.IsEqual(pool.NumTotal, 1);
            Assert.IsEqual(foo.Data, null);
        }

        public class Foo : IPoolable<string>, IDisposable
        {
            public static readonly PoolableStaticMemoryPool<string, Foo> Pool =
                new PoolableStaticMemoryPool<string, Foo>();

            public string Data
            {
                get; private set;
            }

            public void Dispose()
            {
                Pool.Despawn(this);
            }

            public void OnSpawned(string data)
            {
                Data = data;
            }

            public void OnDespawned()
            {
                Data = null;
            }
        }
    }
}

