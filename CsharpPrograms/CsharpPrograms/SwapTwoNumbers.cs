using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPrograms
{
    internal class SwapTwoNumbers
    {
        public static void SwapNumbers()
        {
            Console.WriteLine("Enter First Number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int second = Convert.ToInt32(Console.ReadLine());
            SwapTwoNumbers swap = new SwapTwoNumbers();
            swap.PerformNumberSwap(first, second);
        }
        public void PerformNumberSwap(int f, int s)
        {
            int temp = 0;
            Console.WriteLine("Number before swap first={0} and second={1}", f, s);
            temp = f;
            f = s;
            s = temp;
            Console.WriteLine("Number After swap first={0} and second={1}", f, s);
        }
    }
}
