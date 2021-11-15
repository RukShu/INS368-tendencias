using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RomanConversion;

namespace UnitTestProject1
{
    [TestClass]
    public class NumberValidator_validateRoman
    {
        [TestMethod]
        public void TestCase1()
        {
            string input = "-443";
            bool expected_output = false;
            bool output = NumberValidator.validateRoman(input);
            Assert.AreEqual(expected_output, output);
        }
        [TestMethod]
        public void TestCase2()
        {
            string input = "1234";
            bool expected_output = true;
            bool output = NumberValidator.validateRoman(input);
            Assert.AreEqual(expected_output, output);
        }
        [TestMethod]
        public void TestCase3()
        {
            string input = "0.53";
            bool expected_output = false;
            bool output = NumberValidator.validateRoman(input);
            Assert.AreEqual(expected_output, output);
        }
        [TestMethod]
        public void TestCase4()
        {
            string input = "392a";
            bool expected_output = false;
            bool output = NumberValidator.validateRoman(input);
            Assert.AreEqual(expected_output, output);
        }
        [TestMethod]
        public void TestCase5()
        {
            string input = "0";
            bool expected_output = false;
            bool output = NumberValidator.validateRoman(input);
            Assert.AreEqual(expected_output, output);
        }
    }
}
