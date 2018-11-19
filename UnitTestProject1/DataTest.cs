using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{   [TestClass]
    public class MathTests1
    {
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(12, 30, 42)]
        [DataRow(14, 1, 15)]
        public void Test_Add(int a, int b, int expected)
        {
            var actual = MathHelper.Add(a, b);
            Assert.AreEqual(expected, actual);

        }


        [DataTestMethod]
        [DynamicData(nameof(GetData), DynamicDataSourceType.Method)]

        public void Test_Add_DynamicData_Method(int a, int b, int expected)
        {
            var actual = MathHelper.Add(a, b);
            Assert.AreEqual(expected, actual);
        }

        public static IEnumerable<object[]> GetData()
        {
          yield return new object[] {1, 1, 2};
          yield return new object[] {12,30, 42};
          yield return new object[] { 14,1,15};
        }

        [DataTestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Property)]
        public void Test_Add_DynamicData_Property(int a, int b, int expected)
        {
            var actual = MathHelper.Add(a, b);
            Assert.AreEqual(expected, actual);
        }

        public static IEnumerable<object[]> Data
        {
            get
            {
                yield return new object[] { 1,1,2};
                yield return  new object[] {12,30,42};
                yield return new object[] {14,1,15};
            }
        }

        [DataTestMethod]
        [CustomDataSource]
        public void Test_Add2(int a, int b, int expected)
        {
            var actual = MathHelper.Add(a, b);
            Assert.AreEqual(expected, actual);
        }

        public class CustomDataSourceAttribute : Attribute, ITestDataSource
        {
            public IEnumerable<object[]> GetData(MethodInfo methodInfo)
            {
                yield return new object[]{ 1, 1, 2};
                yield return new object[] {12, 30, 42};
                yield return new object[]{14, 1, 15};
            }

            public string GetDisplayName(MethodInfo methodInfo, object[] data)
            {
                if (data != null)
                    return string.Format(CultureInfo.CurrentCulture, "Custom - {0} ({1})", methodInfo.Name,
                        string.Join(",", data));
                return null;
            }       
        }
    }
}
