using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un número del 1 al 3999 para convertirlo en numeral Romano");
            string input = Console.ReadLine();
            if (!NumberValidator.validateRoman(input))
            {
                Console.WriteLine("Error: Número Inválido");
                return;
            }
            string roman_numeral = NumberConverter.toRoman(Convert.ToInt32(input));
            Console.WriteLine("En numerales romanos " + input + " equivale a " + roman_numeral + ".");
            Console.ReadLine();
        }
    }
}
