using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _2021112201_ISBN_Validator_1;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Isbn10Works()
        {
            string isbn = "8415171803";
            Assert.IsTrue(ISBNValidator.validate_isbn(isbn));
        }
        [TestMethod]
        public void Isbn10WrongArithmeticResult()
        {
            string isbn = "8415171802";
            Assert.IsFalse(ISBNValidator.validate_isbn(isbn));
        }
        [TestMethod]
        public void Isbn13Works()
        {
            string isbn = "9788415171805";
            Assert.IsTrue(ISBNValidator.validate_isbn(isbn));
        }
        [TestMethod]
        public void Isbn13WrongArithmethicResult()
        {
            string isbn = "9788415171801";
            Assert.IsFalse(ISBNValidator.validate_isbn(isbn));
        }
        [TestMethod]
        public void Prefix978Works()
        {
            string isbn = "9788415171805";
            Assert.IsTrue(ISBNValidator.validate_isbn(isbn));
        }
        [TestMethod]
        public void Prefix979Works()
        {
            string isbn = "9798745902567";
            Assert.IsTrue(ISBNValidator.validate_isbn(isbn));
        }
        [TestMethod]
        public void DetectWrongPrefix()
        {
            string isbn = "9778415171805";
            Assert.IsFalse(ISBNValidator.validate_isbn(isbn));
        }
        [TestMethod]
        public void WorksWithDashes()
        {
            string isbn = "979-8-7459-0256-7";
            Assert.IsTrue(ISBNValidator.validate_isbn(isbn));
        }
    }
}
