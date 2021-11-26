using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021112201_ISBN_Validator_1
{
    public class ISBNValidator
    {
        public static bool validate_isbn(string isbn)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < isbn.Length; i++)
            {
                if (Char.IsDigit(isbn[i])) numbers.Add(Convert.ToInt32(isbn[i]) - Convert.ToInt32('0'));
            }
            if (numbers.Count == 10)
            {
                return validate_isbn_10(numbers);
            }
            else if (numbers.Count == 13)
            {
                return validate_isbn_13(numbers);
            }
            return false;
        }
        private static bool validate_isbn_10(List<int> isbn)
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += (i + 1) * isbn[10 - i - 1];
            }
            return sum % 11 == 0;
        }
        private static bool validate_isbn_13(List<int> isbn)
        {
            int mult = 1, sum = 0;
            //Check for prefix
            if (isbn[0] != 9 || isbn[1] != 7 || !(isbn[2] == 8 || isbn[2] == 9)) return false;
            //Arithmetic check
            for(int i = 0; i < 13; i++)
            {
                sum += mult * isbn[i];
                mult = 4 - mult;
            }
            return sum % 10 == 0;
        }
    }
}
