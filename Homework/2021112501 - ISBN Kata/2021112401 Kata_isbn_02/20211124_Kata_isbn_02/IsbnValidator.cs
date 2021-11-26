using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211124_Kata_isbn_02
{
    public class IsbnValidator
    {   
        public static bool isbn_check(string isbn)
        {
            List<int> numbers = new List<int>();
            foreach(char c in isbn)
            {
                if (c == '-') continue;
                if (Char.IsDigit(c)) numbers.Add(Convert.ToInt32(c) - Convert.ToInt32('0'));
                else return false;
            }
            if (numbers.Count == 10)
            {
                return isbn_10_check(numbers);
            }
            else if(numbers.Count == 13)
            {
                return isbn_13_check(numbers);
            }
            return false;
        }

        static bool isbn_10_check(List<int> isbn)
        {
            int sum = 0;
            for(int i = 0, j = 10; i < 10; i++, j--)
            {
                sum += isbn[i] * j;
            }
            return sum % 11 == 0;
        }

        static bool isbn_13_check(List<int> isbn)
        {
            if (isbn[0] != 9 || isbn[1] != 7 || !(isbn[2] == 8 || isbn[2] == 9)) return false;
            int sum = 0, mult = 1;
            for(int i = 0; i < 13; i++)
            {
                sum += isbn[i] * mult;
                mult = 4 - mult;
            }
            return sum % 10 == 0;
        }
    }
}
