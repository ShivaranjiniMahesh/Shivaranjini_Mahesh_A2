using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQAT_Assignment2;

namespace InputValue
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int l = 5;
            int w= 10;
            var rect = new Rectangle();

            l=rect.SetLength(l);
            w=rect.SetWidth(w);
          
            Assert.AreEqual(5, rect.GetLength());
            Assert.AreEqual(10, rect.GetWidth());



        }
    }
}
