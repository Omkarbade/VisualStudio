using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPrograms
{
    internal class VowelConsonant
    {
        public static void CheckVowelorConsonant()
        {
            Console.WriteLine("Enter a Alphabet");
            char ch = Convert.ToChar(Console.ReadLine().ToLower());
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("It is vowel");
                    break;
                case 'e':
                    Console.WriteLine("It is vowel");
                    break;
                case 'i':
                    Console.WriteLine("It is vowel");
                    break;
                case '0':
                    Console.WriteLine("It is vowel");
                    break;
                case 'u':
                    Console.WriteLine("It is vowel");
                    break;
                default:
                    Console.WriteLine("It is Consonant");
                    break;
            }
            Console.ReadKey();
        }
    }
}

