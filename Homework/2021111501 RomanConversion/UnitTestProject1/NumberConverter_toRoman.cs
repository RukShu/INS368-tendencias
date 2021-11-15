using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RomanConversion;

namespace UnitTestProject1
{
    [TestClass]
    public class NumberConverter_toRoman
    {
        [TestMethod]
        public void TestCase1()
        {
            int input = 449;
            string expected_output = "CDXLIX";
            string output = NumberConverter.toRoman(input);
            Assert.AreEqual(expected_output, output);
        }
        [TestMethod]
        public void TestCase2()
        {
            int input = 35;
            string expected_output = "XXXV";
            string output = NumberConverter.toRoman(input);
            Assert.AreEqual(expected_output, output);
        }
        [TestMethod]
        public void TestCase3()
        {
            int input = 3999;
            string expected_output = "MMMCMXCIX";
            string output = NumberConverter.toRoman(input);
            Assert.AreEqual(expected_output, output);
        }
        [TestMethod]
        public void TestCase4()
        {
            int input = 3229;
            string expected_output = "MMMCCXXIX";
            string output = NumberConverter.toRoman(input);
            Assert.AreEqual(expected_output, output);
        }
        [TestMethod]
        public void TestCase5()
        {
            int input = 1;
            string expected_output = "I";
            string output = NumberConverter.toRoman(input);
            Assert.AreEqual(expected_output, output);
        }
    }
}
