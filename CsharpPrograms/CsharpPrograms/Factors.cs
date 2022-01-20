using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPrograms
{
    internal class Factors
    {
        public static void FactorsOfNumber()
        {
            Console.WriteLine("Enter a Number to get its factors: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            int fact = 1;
            for (int i = 1; i <= Number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of given number is: " + fact);
        }
    }
}
