using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQAT_Assignment2;

namespace InputArea
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
            Assert.AreEqual(50, rect.GetArea());
        }
    }
}
