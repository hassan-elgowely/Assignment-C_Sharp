using System.ComponentModel;
using System.Drawing;
using System.Net.NetworkInformation;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region question01
            //1 - Write a program that allows the user to enter a
            //number then print it.


            Console.Write("Enter Number : ");

            string input = Console.ReadLine();
            bool isnum = int.TryParse(input, out int num);

            if (isnum == true)
            {
                Console.WriteLine("Number is : " + num);
            }
            else
            {
                Console.WriteLine("invalid number");
            }

            #endregion


            #region question02

            //2- Write C# program that converts a string to an 
            //integer, but the string contains non - numeric
            //characters.And mention what will happen


            string s1 = "0123456789";
            String s2 = "abcdefgh";

            int num1 = Convert.ToInt32(s1);
            Console.WriteLine(num1);

            //int num2 = Convert.ToInt32(s2);
            //Console.WriteLine(num2);
            //System.FormatException: 'The input string 'abcdefgh' was not in a correct format.'
            #endregion


            #region question03
            //3- Write C# program that Perform a simple arithmetic 
            //operation with floating - point numbers And mention
            //what will happen

            double x = 17.165;
            double y = 18.142;
            double z = Math.Round(x + y, 1);
            Console.WriteLine($"sum = {z}");
            // use math.round to limit the number of digits after the decimal point 
            #endregion


            #region question04
            //4- Write C# program that Extract a substring from a 
            //given string.

            Console.Write("enter a string : ");
            string inputstr = Console.ReadLine();
            string substring = inputstr.Substring(0,3);// start from 0 to 3
            string substring2 = inputstr.Substring(3);// start from 3

            Console.WriteLine(substring);

            #endregion


            #region question05
            //5- Write C# program that Assigning one value type 
            //variable to another and modifying the value of one
            //variable and mention what will happen

            int q = 10;//10
            int w = 50;//50

            q = w; // w = 50 , q = 50

            w = 40; // w = 50 , q = 40
            Console.WriteLine($" {q} , {w}");
            //when assign 2 varible : "take value" 
            #endregion


            #region question06
            // 6- Write C# program that Assigning one reference type 
            // variable to another and modifying the object through
            // one variable and mention what will happen

            point no1 = new point();
            no1.x = 5;

            point no2 = no1;

            no2.x = 7;
            Console.WriteLine(no1.x);
            Console.WriteLine(no2.x);
            #endregion


            #region question07
            //7- Write C# program that take two string variables and 
            //print them as one variable

            string fname = "mohamed";
            string lname = "ahmed";
            Console.WriteLine($"{fname} {lname}");
            #endregion


            #region question08
            // 8- Which of the following statements is correct about 
            //the C#.NET code snippet given below? 
            //     int d;
            //     d = Convert.ToInt32(!(30 < 20));


            // d) The code reports an error.
            #endregion


            #region question09
            //9- Which of the following is the correct output for the 
            //C# code given below? 
            //Console.WriteLine(13 / 2 + " " + 13 % 2);

            //d) 6 1 

            #endregion


            #region question10
            //10-What will be the output of the C# code given below? 
            //int num = 1, z = 5;
            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);

            // d) 7 7 

            #endregion
        }
    }
}
