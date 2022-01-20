using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPrograms
{
    internal class Flipcoin
    {
        public static void CoinFlip()
        {
            int tailCount = 0, headCount = 0;
            Console.WriteLine("Enter a Number to Flip a Coin: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            for (int i = 0; i < Number; i++)
            {
                double randomNum = random.NextDouble();
                if (randomNum < 0.5)
                    tailCount++;
                else
                    headCount++;
            }
            Console.WriteLine("Total number of tails is : " + tailCount);
            Console.WriteLine("Total Number of heads is : " + headCount);

            decimal tailPercentage = (decimal)(tailCount * 100) / Number;
            tailPercentage = Math.Round(tailPercentage, 2);
            decimal headPercentage = (decimal)(headCount * 100) / Number;
            headPercentage = Math.Round(headPercentage, 2);
            Console.WriteLine("Percentage of Tails is: " + tailPercentage + "%");
            Console.WriteLine("Percentage of Heads is: " + headPercentage + "%");
        }
    }
}

