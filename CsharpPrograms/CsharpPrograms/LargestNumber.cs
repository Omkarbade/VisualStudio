using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPrograms
{
    public class LargestNumber
    {
        public static void LargestNumberAmongThreeNos()
        {
            int first, second, third;


            Console.WriteLine("Enter the first number: ");
            first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            third = Convert.ToInt32(Console.ReadLine());


            if (first > second)
            {
                if (first > third)
                {
                    Console.WriteLine("largest number is: " + first);
                }
                else
                {
                    Console.WriteLine("largest number is: " + third);
                }
            }
            else
            {
                if (second > third)
                {
                    Console.WriteLine("largest number is: " + second);
                }
                else
                {
                    Console.WriteLine("largest number is: " + third);
                }
            }
        }
    }
}

