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
            int length = 20;
            int width = 30;
            var rect = new Rectangle();
            rect.SetLength(length);
            rect.SetWidth(width);
            Assert.AreEqual(100, rect.GetPerimeter());

        }
    }
}
