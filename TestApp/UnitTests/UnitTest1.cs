using System;
using NUnit;
using TestApp;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod_AddOneAndZeroShouldReturnOne()
        {
            var sut = new TestClass();

            var actual = sut.Add(1, 0);
            Assert.AreEqual(1, actual);
        }
    }
}
