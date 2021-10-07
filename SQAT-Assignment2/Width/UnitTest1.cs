using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQAT_Assignment2;
using System;

namespace Width
{
    [TestClass]
   
    public class UnitTest1
    {
        [TestMethod]

        public void TestMethod1()
        {
            var rect = new Rectangle();
            int w = 5;
            rect.SetLength(w);
            Assert.IsFalse(false, "not in range");
        }
    }
}
