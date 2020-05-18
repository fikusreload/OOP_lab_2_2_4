using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMax()
        {
            Assert.AreEqual(10, OOP_lab_2_2_4.Program.Max(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
        }

        [TestMethod]
        public void TestSum()
        {
            Assert.AreEqual(0, OOP_lab_2_2_4.Program.Sum(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
        }
    }
}
