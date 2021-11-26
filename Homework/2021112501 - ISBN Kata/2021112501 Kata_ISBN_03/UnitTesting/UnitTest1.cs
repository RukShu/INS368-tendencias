using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _20211125_Kata_ISBN_03;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void isbn10_works()
        {
            string isbn = "0330284983";
            Assert.IsTrue(ISBNValidator.is_isbn_valid(isbn));
        }
        [TestMethod]
        public void isbn13_works()
        {
            string isbn = "9786017151133";
            Assert.IsTrue(ISBNValidator.is_isbn_valid(isbn));
        }
        [TestMethod]
        public void isbn_with_dashes_works()
        {
            string isbn = "0-330-28498-3";
            Assert.IsTrue(ISBNValidator.is_isbn_valid(isbn));
        }
        [TestMethod]
        public void isbn_13_prefix_978_works()
        {
            string isbn = "978-602-8328-22-7";
            Assert.IsTrue(ISBNValidator.is_isbn_valid(isbn));
        }
        [TestMethod]
        public void isbn_13_prefix_979_works()
        {
            string isbn = "979-10-90636-07-1";
            Assert.IsTrue(ISBNValidator.is_isbn_valid(isbn));
        }
        [TestMethod]
        public void isbn_10_arithmetically_wrong_fails()
        {
            string isbn = "950-04-0442-1";
            Assert.IsFalse(ISBNValidator.is_isbn_valid(isbn));
        }
        [TestMethod]
        public void isbn_13_arithmetically_wrong_fails()
        {
            string isbn = "978-607-455-035-3";
            Assert.IsFalse(ISBNValidator.is_isbn_valid(isbn));
        }
        [TestMethod]
        public void isbn_with_not_enough_numbers_fails()
        {
            string isbn = "5424084";
            Assert.IsFalse(ISBNValidator.is_isbn_valid(isbn));
        }
        [TestMethod]
        public void isbn_with_non_digits_other_than_dashes_fails()
        {
            string isbn = "978-606-8126-35-7a";
            Assert.IsFalse(ISBNValidator.is_isbn_valid(isbn));
        }
        [TestMethod]
        public void isbn_13_with_wrong_prefix_fails()
        {
            string isbn = "977-612-45165-9-7";
            Assert.IsFalse(ISBNValidator.is_isbn_valid(isbn));
        }

    }
}
