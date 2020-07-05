using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            int sum = 3;

            var result = 3;

            Assert.AreEqual(result, sum);
        }
    }
}
