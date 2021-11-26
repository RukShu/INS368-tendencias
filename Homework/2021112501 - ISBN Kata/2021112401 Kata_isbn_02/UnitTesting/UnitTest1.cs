using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _20211124_Kata_isbn_02;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void isbn10_works()
        {
            string isbn = "1574980939";
            Assert.IsTrue(IsbnValidator.isbn_check(isbn));
        }

        [TestMethod]
        public void isbn13_works()
        {
            string isbn = "9780800042011";
            Assert.IsTrue(IsbnValidator.isbn_check(isbn));
        }
        [TestMethod]
        public void isbn10_detect_wrong_arithmetic()
        {
            string isbn = "1574980938";
            Assert.IsFalse(IsbnValidator.isbn_check(isbn));
        }
        [TestMethod]
        public void isbn13_detect_wrong_arithmethic()
        {
            string isbn = "9780800042012";
            Assert.IsFalse(IsbnValidator.isbn_check(isbn));
        }
        [TestMethod]
        public void isbn_checks_for_number_quantity()
        {
            string isbn = "34349343";
            Assert.IsFalse(IsbnValidator.isbn_check(isbn));
        }
        [TestMethod]
        public void isbn_checker_works_with_dashes()
        {
            string isbn = "0-545-01022-5";
            Assert.IsTrue(IsbnValidator.isbn_check(isbn));
        }
        [TestMethod]
        public void isbn13_detects_wrong_prefix()
        {
            string isbn = "9770800042012";
            Assert.IsFalse(IsbnValidator.isbn_check(isbn));
        }
        [TestMethod]
        public void isbn13_978_prefix_works()
        {
            string isbn = "978-3-16-148410-0";
            Assert.IsTrue(IsbnValidator.isbn_check(isbn));
        }
        [TestMethod]
        public void isbn13_979_prefix_works()
        {
            string isbn = "979-10-90636-07-1";
            Assert.IsTrue(IsbnValidator.isbn_check(isbn));
        }
    }
}
