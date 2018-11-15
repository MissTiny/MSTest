using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void Test_Add()
        {
            var actual = MathHelper.Add(1, 1);
            var expected = 2;
            Assert.AreEqual(expected, actual);
        }
    }

    public class MathHelper
    {
        public static int Add(int a, int b) => a + b;
    }
}
