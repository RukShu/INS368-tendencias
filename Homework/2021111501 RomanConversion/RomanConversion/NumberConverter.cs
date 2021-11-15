using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanConversion
{
    public class NumberConverter
    {
        static public string toRoman(int number) //Return a number in Roman Numerals
        {
            string[] roman_u = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
            string[] roman_d = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"};
            string[] roman_c = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] roman_t = { "", "M", "MM", "MMM" };
            string output = "";

            int u = number % 10,
                d = (number / 10) % 10,
                c = (number / 100) % 10,
                t = (number / 1000) % 10;

            output = roman_t[t] + roman_c[c] + roman_d[d] + roman_u[u];

            return output;
        }
    }
}
