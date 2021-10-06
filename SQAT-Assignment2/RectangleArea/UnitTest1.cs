using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQAT_Assignment2;

namespace RectangleArea
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var rect = new Rectangle();

            rect.GetLength();
            rect.GetWidth();

            Assert.AreEqual(1, rect.GetArea());
        }
    }
}
