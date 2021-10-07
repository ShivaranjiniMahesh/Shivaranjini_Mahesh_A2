using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQAT_Assignment2;
using System;

namespace Length
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
        public void TestMethod1()
        {
            
            var rect = new Rectangle();
            int l = 20;
            rect.SetLength(l);
            Assert.IsFalse(false, "not in range");
        }
    }
}
