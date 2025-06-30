using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Threading.Channels;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region Q1
            //1- Write a program that takes a number from the user then print yes if that number can be 
            //   divided by 3 and 4 otherwise print no.

            // Example(1)
            //    Input: 12
            //    Output: Yes
            // Example(2)
            //    Input: 9
            //    Output: No

            Console.Write("Enter Number : ");
            int.TryParse(Console.ReadLine(), out int num);

            if (num % 4 == 0 && num % 3 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }


            #endregion


            #region Q2
            //2- Write a program that allows the user to insert an integer then print negative if it is 
            //   negative number otherwise print positive.

            //Example(1)
            //    Input: -5
            //    Output: negative
            //Example(2)
            //    Input: 10
            //    Output: positive


            Console.Write("Enter Number : ");
            int.TryParse(Console.ReadLine(), out int num2);

            if (num2 < 0)
            {
                Console.WriteLine("Negative Number");
            }
            else if (num2 > 0)
            {
                Console.WriteLine("Positive Number");
            }
            else if (num2 == 0)
            {
                Console.WriteLine("number = 0");
            }

                #endregion


            #region Q3
                //3- Write a program that takes 3 integers from the user then prints the max element and 
                //   the min element.
                //Example (1) 
                //    Input:7,8,5 
                //    Output: 
                //    max element = 8 
                //    min element = 5 
                //Example (2) 
                //    Input: 3 6 9 
                //    Outputs: 
                //    Max element = 9 
                //    Min element = 3 

                Console.Write("Enter 3 Number : ");
            int.TryParse(Console.ReadLine(), out int x);
            int.TryParse(Console.ReadLine(), out int y);
            int.TryParse(Console.ReadLine(), out int z);

            if (x > y && x > z)
            {
                Console.WriteLine($"max element = {x} ");
                if (y > z)
                {
                    Console.WriteLine($"min element = {z} ");
                }
                else
                {
                    Console.WriteLine($"min element = {y} ");
                }
            }
            else if (y > x && y > z)
            {
                Console.WriteLine($"max element = {y}");
                if (x > z)
                {
                    Console.WriteLine($"min element = {z} ");
                }
                else
                {
                    Console.WriteLine($"min element = {x} ");
                }
            }
            else if (z > x && z > y)
            {
                Console.WriteLine($"max element = {z}");
                if (x > y)
                {
                    Console.WriteLine($"min element = {y} ");
                }
                else
                {
                    Console.WriteLine($"min element = {x} ");
                }
            }
            else
            {
                Console.WriteLine("enter valid number");
            }
                #endregion


            #region Q4
                //4- Write a program that allows the user to insert an integer number then check If a 
                //number is even or odd.
                Console.Write("Enter NUmber : ");
            int.TryParse(Console.ReadLine(), out int num3);

            if (num3 % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            #endregion


            #region Q5
            //5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) 
            //then print(vowel) otherwise print(consonant). 
            //Example(1)
            //    Input: O
            //    Output: vowel
            //Example(2)
            //    Input: b
            //    Output: Consonant

            Console.Write("Enter a Char : ");
            char.TryParse(Console.ReadLine(), out char c);

            switch (c)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("vowel");
                    break;
                default:
                    Console.WriteLine("consonant");
                    break;
            }
            #endregion
        }
    }
}
