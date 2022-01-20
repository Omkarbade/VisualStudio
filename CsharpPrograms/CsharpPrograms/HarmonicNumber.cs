using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPrograms
{
    internal class HarmonicNumber
    {
        public static void PrintHarmonicNumber()
        {
            Console.WriteLine("Enter a number to print Harmonic Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            double harmonicSum = 0.0;
            for (int count = 0; count <= number; count++)
            {
                if (count == 0)
                    Console.WriteLine("Please enter positive number: ");
                else
                    harmonicSum += 1 / (float)count;
            }
            Console.WriteLine("Harmonic Number is: " + harmonicSum);
        }
    }
}
