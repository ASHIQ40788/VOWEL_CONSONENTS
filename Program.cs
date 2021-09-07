using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOWEL_CONSONENTS
{
    class Program
    {
        //2. Write a program to check whether the input alphabet is a vowel or not.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Alphabet");
            char ch = Convert.ToChar(Console.ReadLine().ToLower());
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("It is vowel");
                    break;
                case 'i':
                    Console.WriteLine("It is vowel");
                    break;
                case 'o':
                    Console.WriteLine("It is vowel");
                    break;
                case 'u':
                    Console.WriteLine("It is vowel");
                    break;
                case 'e':
                    Console.WriteLine("It is vowel");
                    break;
                default:
                    Console.WriteLine("It Is consonant");
                    break;
            }
            Console.ReadKey();
        }
    }
}