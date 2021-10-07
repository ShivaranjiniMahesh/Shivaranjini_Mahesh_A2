using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQAT_Assignment2;
using System;

namespace RectangleDefaultConstructor
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Rectangle()
        {
            
            var rect = new Rectangle();

            Assert.AreEqual(1, rect.GetLength());
            Assert.AreEqual(1 , rect.GetWidth());

        }
    }
}
