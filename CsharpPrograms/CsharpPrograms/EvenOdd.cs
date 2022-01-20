using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPrograms
{
    internal class EvenOdd
    {
        public static void CheckEvenorOdd()
        {
            int a;

            Console.WriteLine("Enter a number to check it is even or odd: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Number is even number" + a);
            }
            else
            {
                Console.WriteLine("Number is odd number" + a);
            }
        }
    }
}
