/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 сентября 2025 06:50:28
 * Version: 1.0.11
 */

using System.Collections.Generic;
using NUnit.Framework;
using Assert = ModestTree.Assert;

namespace Zenject.Tests
{
    [TestFixture]
    public class TestTestUtil
    {
        [Test]
        public void TestTrue()
        {
            Assert.That(TestListComparer.ContainSameElements(
                new List<int> {1},
                new List<int> {1}));

            Assert.That(TestListComparer.ContainSameElements(
                new List<int> {1, 2},
                new List<int> {2, 1}));

            Assert.That(TestListComparer.ContainSameElements(
                new List<int> {1, 2, 3},
                new List<int> {3, 2, 1}));

            Assert.That(TestListComparer.ContainSameElements(
                new List<int>(),
                new List<int>()));
        }

        [Test]
        public void TestFalse()
        {
            Assert.That(!TestListComparer.ContainSameElements(
                new List<int> {1, 2, 3},
                new List<int> {3, 2, 3}));

            Assert.That(!TestListComparer.ContainSameElements(
                new List<int> {1, 2},
                new List<int> {1, 2, 3}));
        }
    }
}



