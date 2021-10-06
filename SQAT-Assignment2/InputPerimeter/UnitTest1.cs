using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQAT_Assignment2;
using System;
namespace InputPerimeter
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int length = 5;
            int width = 10;
            var rect = new Rectangle();
            rect.SetLength(length);
            rect.SetWidth(width);
            Assert.AreEqual(30, rect.GetPerimeter());

        }
    }
}
