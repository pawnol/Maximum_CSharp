/*
 * Maximum
 * Pawelski
 * 1/3/2022
 * Read the code and run the program a few times so you understand
 * what the program does and how it works. Once you understand what
 * the program does and how it works, answer the questions found
 * on the activity sheet.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, maximum;
            Console.Write("Enter a number >> ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number >> ");
            number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 < number2)
            {
                maximum = number2;
            }
            else
            {
                maximum = number1;
            }
            Console.WriteLine("The maximum is " + maximum + ".");
        }
    }
}
