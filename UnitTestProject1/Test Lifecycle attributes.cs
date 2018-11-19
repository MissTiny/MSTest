using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TestClass1
    {
       

        [TestMethod]
        public void Test1()
        {

        }
    }

    [TestClass]
    public class TestClass2 
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Console.WriteLine("ClassInitialize");
        }

        [ClassCleanup]
        public static void Dispose()
        {
            Console.WriteLine("ClassCleanup");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            Console.WriteLine("TestInitialize");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Console.WriteLine("TestCleanup");
        }

        [TestMethod]
        public void Test3()
        {

        }

        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            Console.WriteLine("AssemblyInitialize");
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Console.WriteLine("AssemblyCleanup");
        }
    }



}
