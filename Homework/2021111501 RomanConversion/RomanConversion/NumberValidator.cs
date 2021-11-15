using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanConversion
{
    public class NumberValidator
    {
        static public bool validateRoman(string number) //Returns true if the number is valid for the Roman Conversion.
        {
            for(int i = 0; i < number.Length; i++)
            {
                if (!Char.IsDigit(number[i])) return false;
            }
            int int_number = Convert.ToInt32(number);
            if (int_number < 1 || int_number > 3999) return false;
            return true;
        }
    }
}
