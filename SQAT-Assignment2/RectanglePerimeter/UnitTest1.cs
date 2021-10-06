using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQAT_Assignment2;
using System;

namespace RectanglePerimeter
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            var rect= new Rectangle();

            rect.GetLength();
            rect.GetWidth();

            Assert.AreEqual(4 , rect.GetPerimeter());
        }
    }
}
