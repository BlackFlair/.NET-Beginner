using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HelloWorld;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = "";
            List<int> input = new List<int>() { };

            Programs prog = new Programs();

            Assert.AreEqual(result, prog.count(input));
        }

        [TestMethod]
        public void TestMethod2()
        {
            string result = "1 appears 2 times\r\n";
            List<int> input = new List<int>() {1,1};

            Programs prog = new Programs();

            Assert.AreEqual(result, prog.count(input));
        }

        [TestMethod]
        public void TestMethod3()
        {
            string result = "1 appears 2 times\r\n2 appears 1 times\r\n";
            List<int> input = new List<int>() { 1,2,1 };

            Programs prog = new Programs();

            Assert.AreEqual(result, prog.count(input));
        }

        [TestMethod]
        public void TestMethod4()
        {
            string result = "1 appears 2 times\r\n2 appears 2 times\r\n3 appears 1 times\r\n4 appears 1 times\r\n";
            List<int> input = new List<int>() { 1, 2, 1,2,3,4 };

            Programs prog = new Programs();

            Assert.AreEqual(result, prog.count(input));
        }

        [TestMethod]
        public void TestMethod5()
        {
            string result = "1 appears 2 times\r\n2 appears 2 times\r\n";
            List<int> input = new List<int>() { 1, 2, 1, 2 };

            Programs prog = new Programs();

            Assert.AreEqual(result, prog.count(input));
        }
    }
}
