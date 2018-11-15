using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class AssertTest
    {


        [TestMethod]
        [Ignore]
        public void EqualTest()
        {
            Assert.AreEqual(10, 5 + 5);
            Assert.AreEqual(10, 1 + 2);
            Assert.AreEqual(20, 1 + 2);
        }



        [TestMethod]
        [Ignore]
        public void AssertTest2()
        {
            Assert.IsInstanceOfType(5, typeof(int));
        }



        [TestMethod]
        [Ignore]
        public void CollectionAssertTest()
        {
            CollectionAssert.IsNotSubsetOf(new[] { 1, 2, 3 }, new[] { 1, 2 });
        }



        [TestMethod]
        [Ignore]
        public void StringAssertTestWithRegex()
        {
            var reg = new Regex(@"^j\S*e$");
            StringAssert.Matches("joyce", reg);
            StringAssert.Matches("joydce", reg);
            StringAssert.DoesNotMatch("joyce1", reg);
            StringAssert.DoesNotMatch("joy ce", reg);
        }

        [TestMethod]
        [Ignore]
        public void ExceptionTest()
        {
            Assert.ThrowsException<ArgumentNullException>( () => new Regex(null));
            Assert.ThrowsException<ArgumentException>(() => new Regex("1"));
        }

        [TestMethod]
        public void Sample8()
        {
            if (DateTime.Now.Hour != 12)
                Assert.Inconclusive("Must be executed at noon");
        }

    }
}
