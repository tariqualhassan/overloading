using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using methodoverloadingandproperty;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Box newbox = new Box (5, 25, 14);

            Assert.AreNotSame();
        }
    }
}
