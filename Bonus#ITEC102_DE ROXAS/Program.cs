using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_ITEC102_DE_ROXAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Bonus Question
             * accepts character and determine if it is consonant or a vowel
             * Create ng console application a consonant or a vowel 
             * 
             * Consonant
             * Vowel
             * A E I O U
             */

          

            Console.WriteLine("Character Input Analyzer");
            Console.Write("Input A character: ");
            char getChar = Convert.ToChar(Console.ReadLine());


           if (getChar == 'A' || getChar == 'a' || getChar == 'E' || getChar == 'e' || getChar == 'I' || getChar == 'i' || getChar == 'O' || getChar == 'o' || getChar == 'U' || getChar == 'u')
            {
                Console.WriteLine("The character " + getChar + " is a Vowel.");
                Console.ReadKey();
            }
            else if (getChar == 'B' || getChar == 'C' || getChar == 'D' || getChar == 'F' || getChar == 'G' || getChar == 'H' || getChar == 'J' || getChar == 'K' || getChar == 'L' || getChar == 'M' || getChar == 'N' || getChar == 'P' || getChar == 'Q' || getChar == 'R' || getChar == 'S' || getChar == 'T' || getChar == 'V' || getChar == 'W' || getChar == 'X' || getChar == 'Y' || getChar == 'Z' ||
                    getChar == 'b' || getChar == 'c' || getChar == 'd' || getChar == 'f' || getChar == 'g' || getChar == 'h' || getChar == 'j' || getChar == 'k' || getChar == 'l' || getChar == 'm' || getChar == 'n' || getChar == 'p' || getChar == 'q' || getChar == 'r' || getChar == 's' || getChar == 't' || getChar == 'v' || getChar == 'w' || getChar == 'x' || getChar == 'y' || getChar == 'z')
            {
                Console.WriteLine("The character " + getChar + " is a Consonant.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid character.");
                Console.WriteLine("Please Try Again....");
                Console.ReadKey();
            }
        }
    }
}
