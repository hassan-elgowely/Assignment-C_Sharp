using System;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region Q6
            // 6- Write a program that allows the user to insert an integer then print 
            //    all numbers between 1 to that number.
            
            bool check;
            int num;
            do
            {
                Console.Write("Enter Number : ");
                check = int.TryParse(Console.ReadLine(), out  num);
            } 
            while (!check);
                for (int x = 1; x <= num; x++)
                Console.WriteLine(x);

            #endregion


            #region Q7
            // 7- Write a program that allows the user to insert an integer then  
            //    print a multiplication table up to 12.
            bool check2;
            int num2;

            do
            {
                Console.Write("Enter Number : ");
                check2 =int.TryParse(Console.ReadLine(), out num2);
            }
            while (!check2);
            for (int y = 0; y <= 12; ++y)
            {
                Console.WriteLine(y*num2);
                
            }
            #endregion


            #region Q8
            // 8- Write a program that allows to user to insert number then print all 
            //    even numbers between 1 to this number
            bool check3;
            int num3;
            do
            {
                Console.Write("Enter Number : ");
                check3 = int.TryParse(Console.ReadLine(), out num3);
            }
            while (!check3);
            if (num3 > 0)    
                for (int z = 1; z <= num3; z++)
                {
                    if (z % 2 == 0)
                    Console.WriteLine(z);
                }
            else if (num3 < 0)
                for (int z = 1; z >= num3; z--)
                {
                    if (z % 2 == 0)
                        Console.WriteLine(z);
                }

            #endregion


            #region Q9
            // 9- Write a program that takes two integers then prints the power. 
            bool check4, check5;
            int no1, no2;
            double result = 1;

            do
            {
                Console.WriteLine("Enter Number 1 : ");
                check4 = int.TryParse(Console.ReadLine(), out no1);
                Console.WriteLine("Enter Number 2 : ");
                check5 = int.TryParse(Console.ReadLine(), out no2);
            }
            while (!(check4 && check5));
            if (no2 > 0)
                for (int i = 1; i <= no2; i++)
                {
                    result *= no1;
                }
            else if (no2 == 0)
                {
                result = 1;
                }
            else if (no2 < 0)
                for (int i = 1; i <= no2; i++)
                {
                    result *= no1;
                    result = (1 / result);
                }
                Console.WriteLine(result);

            #endregion


            #region Q10
            // 10- Write a program to enter marks of five subjects and calculate 
            //     total, average and percentage.
            int mygrade;
            int sum = 0;
            bool check6;
            for (int s = 1; s <= 5; s++) 
            {
                do
                {
                    Console.WriteLine($"Enter the grade for subject {s} ");
                    check6 = int.TryParse(Console.ReadLine(), out mygrade);
                    }while (!check6);
                    sum = sum + mygrade;
            }
            int total = sum;
            int avg = total / 5;
            int per = (total * 100) / 500;
            Console.WriteLine($"total {total} average {avg} percentage {per}");
            #endregion


            #region Q11
            // 11- Write a program to input the month number and print the number of 
            //     days in that month. 
            bool check7;
            int m;
            int[] monthnum;
            do
            {
                monthnum = [0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
                Console.Write("Enter Month Number : ");
                check7 = int.TryParse(Console.ReadLine(), out m);
            }
            while (!check7);
                if (m >= 1 && m <= 12)
                Console.WriteLine($"Number of days in that month = {monthnum[m]}");
                else
                Console.WriteLine("enter valid month number");
                #endregion


            #region Q12
            // 12- Write a program to create a Simple Calculator. 
            bool check8, check9, check10;
            int number1, number2;
            char c;

            do
            {
                Console.Write("Enter Num 1 : ");
                check8 = int.TryParse(Console.ReadLine(), out number1);
                Console.Write("Enter the operator : ");
                check9 = char.TryParse(Console.ReadLine(), out c);
                Console.Write("Enter Num 2 : ");
                check10 = int.TryParse(Console.ReadLine(), out number2);
            }
            while (!(check8 && check9 && check10));

                switch (c)
            {
                case '+':
                    Console.WriteLine(number1 + number2);
                    break;
                case '-':
                    Console.WriteLine(number1 - number2);
                    break;
                case '*':
                    Console.WriteLine(number1 * number2);
                    break;
                case '/':
                    Console.WriteLine(number1 / number2);
                    break;
                case '%':
                    Console.WriteLine(number1 % number2);
                    break;
                default:
                    Console.WriteLine("check the operator");
                    break;
            }
            #endregion


            #region Q13
            // 13- Write a program to allow the user to enter a string and print the 
            //     REVERSE of it.
            Console.WriteLine("Enter text : ");
            string text = Console.ReadLine();
            Console.WriteLine(text.Length);
            for (int p = text.Length-1; p >= 0;p--)
                Console.WriteLine(text[p]);

            //other way
            //char[] chtext = text.ToCharArray();
            //Array.Reverse(chtext);
            //string reversechtext = new string(chtext);
            //Console.WriteLine(reversechtext);


            #endregion


            #region Q14
            // 14- Write a program to allow the user to enter int and print the REVERSED of it.
            bool check11;
            int number05 , reversnum = 0 ;

            do
            {
                Console.WriteLine("Enter the Number : ");
                check11 = int.TryParse(Console.ReadLine(), out number05);
            }
            while (!check11);

            while (number05 != 0)
            {

                int digit = number05 % 10;
                reversnum = reversnum * 10 + digit;
                number05 /= 10;
            }
            Console.WriteLine(reversnum);


            #endregion


            #region Q15
            // 15- Write a program in C# Sharp to find prime numbers within a range of numbers.
            bool check12, check13 , check14;
            int startnum, endnum, l;

            do
            {
                Console.WriteLine("Enter start number : ");
                check12 = int.TryParse(Console.ReadLine(), out startnum);
                Console.WriteLine("Enter end number : ");
                check13 = int.TryParse(Console.ReadLine(), out endnum);
            } while (!(check12 && check13));
            for (l = startnum; l <= endnum; l++)
            {
                check14 = true;

                for (int p = 2; p < l; p++)
                {
                    if (l % p == 0)
                    {
                        check14 = false;
                        break;
                    }
                }
                if (check14)
                {
                    Console.WriteLine(l);
                }
            }
            #endregion


            #region Q17
            // 17- Create a program that asks the user to input three points (x1, y1), 
            //     (x2, y2), and(x3, y3), and determines whether these points lie on a
            //     single straight line.

            
                Console.WriteLine("Enter point 1 : ");
                int.TryParse(Console.ReadLine(), out int a1);
                int.TryParse(Console.ReadLine(), out int b1);
                Console.WriteLine("Enter point 2 : ");
                int.TryParse(Console.ReadLine(), out int a2);
                int.TryParse(Console.ReadLine(), out int b2);
                Console.WriteLine("Enter point 1 : ");
                int.TryParse(Console.ReadLine(), out int a3);
                int.TryParse(Console.ReadLine(), out int b3);

            
           
            if ((b2 - b1) * (a3 - a2) == (b3 - b2) * (a2 - a1))
            {
                Console.WriteLine("3 point on straight line");
            }
            else
            {
                Console.WriteLine("3 point not on straight line");
            }
            #endregion


            #region Q18
            // 18- Within a company, the efficiency of workers is evaluated based on 
            //     the duration required to complete a specific task. A worker's 
            //     efficiency level is determined as follows:  -If the worker completes the job within 2 to 3 hours, they are
            //     considered highly efficient.  - If the worker takes 3 to 4 hours, they are instructed to increase
            //     their speed.  - If the worker takes 4 to 5 hours, they are provided with training to
            //     enhance their speed.  - If the worker takes more than 5 hours, they are required to leave the
            //     company.
            //     To calculate the efficiency of a worker, the time taken for the task is
            //     obtained via user input from the keyboard.


            bool check21;
            int hours;
            do
            {
                Console.WriteLine("enter hours");
                check21 = int.TryParse(Console.ReadLine(), out hours);

            } while (!check21);
            if (hours >= 2 && hours <= 3) 
            {
                Console.WriteLine("highly efficient");
            }
            else if (hours >= 3 && hours <= 4)
            {
                Console.WriteLine("instructed to increasetheir speed");
            }
            else if (hours >= 4 && hours <= 5)
            {
                Console.WriteLine("provided with training to enhance their speed");
            }
            else if (hours >= 5)
            {
                Console.WriteLine("required to leave the company");
            }
            #endregion


        }
    }
}
