using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDPractice;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void Parse_Binary_1()
        {
            int[] Test1 = new int[] {0,0,0,1};
            var target = new Calculator();

            var actual = target.Parse(Test1);
            var expected  = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parse_Binary_2()
        {
            int[] Test1 = new int[] { 0, 0, 1, 0 };
            var target = new Calculator();

            var actual = target.Parse(Test1);
            var expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parse_Binary_5()
        {
            int[] Test1 = new int[] { 0, 1, 0, 1 };
            var target = new Calculator();

            var actual = target.Parse(Test1);
            var expected = 5;
            Assert.AreEqual(expected, actual);
        }
    }
}
