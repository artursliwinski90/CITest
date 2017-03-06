using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApp;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_AddOneAndZeroShouldReturnOne()
        {
            var sut = new TestClass();

            var actual = sut.Add(1, 0);
            Assert.AreEqual(1, actual);
        }
    }
}
