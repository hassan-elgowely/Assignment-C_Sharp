using System.Buffers.Text;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment06
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region Q1
            //// 1- Explain the difference between passing (Value type 
            ////    parameters) by value and by reference then write a suitable c# example.

            ///// ===> passing value type parameters by value :
            /////      1 - when send a variable to a function ==> it copies the variable
            /////      2 - any update to the variable , has no effect on the original variable 
            /////      3 - affecting the variable in the function only

            ////example 01

            //static void Sum5(int x, int y)
            //{
            //    x += 5;
            //    y += 5;

            //}

            //int num1 = 7, num2 = 3;
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //Console.WriteLine("-------------------");
            //Sum5(num1, num2);
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);

            //Console.WriteLine("-----------------------------------------------------------------");

            ///// ===> passing value type parameters by reference :
            /////      1 - when send a variable to a function ==> it operates on the original variable
            /////      2 - any update to the variable has an effect 
            /////      3 - effect on the variable inside and outside the function
            /////      4 - used "ref" with the parameters

            //// Example 02

            //static void Sum10(ref int x, ref int y)
            //{
            //    x += 10;
            //    y += 10;

            //}

            //int num3 = 7, num4 = 3;
            //Console.WriteLine(num3);
            //Console.WriteLine(num4);
            //Console.WriteLine("-------------------");
            //Sum10(ref num3, ref num4);
            //Console.WriteLine(num3);
            //Console.WriteLine(num4);

            #endregion


            #region Q2
            //// 2- Explain the difference between passing (Reference type 
            ////    parameters) by value and by reference then write a suitable c# example.


            ///// ===> passing reference type parameters by value
            /////      1 - sends copies of reference , but does not send original reference
            /////      2 - object value can be updated
            /////      3 - reference can not be updated when referring to new object

            //// Example 01 

            //static int Sumarr(int[] numbers)
            //{ 
            //    int sum = 0;
            //    numbers[0] = 100; 
            //    if (numbers != null) 
            //    for (int i = 0; i < numbers.Length; i++)
            //            sum += numbers[i];
            //    return sum;
            //}

            //int[] num = { 1, 2, 3, 4, 5, 6, 7 };
            //int sum = 0;
            //for (int i = 0;i < num.Length;i++)
            //{
            //    sum += num[i];
            //}
            //Console.WriteLine(sum);
            //Console.WriteLine("----------------");
            //Console.WriteLine(Sumarr(num));


            //// Example 02

            //static string Hello(string name)
            //{
            //    return name = "Hello " + name; 
            //}

            //Console.Write("Enter Your Name : ");
            //string? name = Console.ReadLine();
            //Console.WriteLine(Hello(name));

            //Console.WriteLine("--------------------------------------------------------");

            ///// ===> passing reference type parameters by reference
            /////      1 - it send the reference
            /////      2 - the reference is effected whether update value or referring to new object 
            /////      3 - used ref with the parameters

            //// Example 01

            //static int Sumarr02(int[] numbers)
            //{
            //    int sum = 0;
            //    numbers = [ 50, 60, 70, 80, 90, 100 ];
            //    if (numbers != null)
            //        for (int i = 0; i < numbers.Length; i++)
            //            sum += numbers[i];
            //    return sum;
            //}

            //int[] num2 = { 1, 2, 3, 4, 5, 6, 7 };
            //int sum2 = 0;
            //for (int i = 0; i < num.Length; i++)
            //{
            //    sum2 += num2[i];
            //}
            //Console.WriteLine(sum2);
            //Console.WriteLine("----------------");
            //Console.WriteLine(Sumarr02(num2));

            //// Example 02

            //static string StaticMessage(string name)
            //{
            //    name = "Hello " + name;
            //    name = new string("You can not register !");
            //    return name;
            //}

            //Console.Write("Enter Your Name : ");
            //string? name2 = Console.ReadLine();
            //Console.WriteLine(StaticMessage(name));

            #endregion


            #region Q3
            //// 3- Write a c# Function that accept 4 parameters from user and 
            ////    return result of summation and subtracting of two numbers

            //static void SumAndSub(int n1, int n2 , out int sum , out int sub )
            //{
            //    sum = n2 + n1;
            //    sub = n2 - n1;
            //}

            //bool flag, flag2;
            //int x, y , sum , sub;
            //do
            //{
            //    Console.Write("Enter Number 1 : ");
            //    flag = int.TryParse(Console.ReadLine(), out x);
            //    Console.Write("Enter Number 2 : ");
            //    flag2 = int.TryParse(Console.ReadLine(), out y);
            //}while(!(flag && flag2));

            //SumAndSub(x, y,out sum,out sub);
            //Console.WriteLine($"summation ==> {sum}");
            //Console.WriteLine($"subtracting ==> {sub}");

            #endregion


            #region Q4
            //// 4- Write a program in C# Sharp to create a function to calculate the sum of 
            ////    the individual digits of a given number.
            ////    Output should be like
            ////    Enter a number: 25
            ////    The sum of the digits of the number 25 is: 7

            //static int SumIndivdualDigits (int value)
            //{
            //    int digit , result = 0;
            //    while (value != 0)
            //    {
            //        digit = value % 10;
            //        result += digit;
            //        value /= 10;
            //    }
            //    return result;
            //}




            //bool flag;
            //int num;
            //do
            //{
            //    Console.Write("Enter a Number : ");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //}while (!flag);
            //Console.WriteLine("-----------");
            //Console.WriteLine($"he sum of the digits of the number {num} is: {SumIndivdualDigits(num)}");

            #endregion


            #region Q5
            //// 5- Create a function named "IsPrime", which receives an integer number 
            ////    and retuns true if it is prime, or false if it is not: 

            //static bool IsPrime (int x)
            //{
            //    if (x <= 1)
            //        return false;

            //    int i = 2;
            //    while (i*i <=x)
            //    {
            //        if (x % i == 0)
            //            return false;
            //        i++;
            //    }
            //    return true;
            //}

            //bool flag;
            //int num;
            //do
            //{
            //    Console.Write("Enter a Number : ");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //} while (!flag);
            //Console.WriteLine("-----------");

            //Console.WriteLine(IsPrime(num));

            #endregion


            #region Q6
            ////  6- Create a function named MinMaxArray, to return the minimum and 
            ////     maximum values stored in an array, using reference parameters

            //static void MinMaxArray(ref int[] arr, out int min, out int max)
            //{

            //    min = arr.Min();
            //    max = arr.Max();
            //}

            //bool flag ,flag2;
            //int index;
            //do
            //{
            //    Console.Write("Enter The Length Of Array : ");
            //    flag = int.TryParse(Console.ReadLine(), out index);
            //} while (!flag);
            //int[] arr = new int[index];
            //for (int i = 0; i < index; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"Enter a Number {i + 1}");
            //        flag2 = int.TryParse(Console.ReadLine(), out arr[i]);
            //    }while (!flag2);
            //}
            //Console.WriteLine("-----------");

            //int min, max;
            //MinMaxArray(ref arr, out min, out max);
            //Console.WriteLine(min);
            //Console.WriteLine(max);

            #endregion


            #region Q7
            // 7- Create an iterative (non-recursive) function to calculate the factorial 
            //    of the number specified as parameter

            //static int Factorial(int x)
            //{ 
            //    if (x == 0) 
            //        return 1;
            //    if (x == 1) 
            //        return 1;
            //    int mal = 1;
            //    if (x > 1)
            //    {
            //        for (int i = 2; i <= x; i++)
            //            mal *= i;
            //    }
            //    return mal;
            //}

            //bool flag;
            //int num;
            //do
            //{
            //    Console.Write("Enter a Number : ");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //} while (!flag);
            //Console.WriteLine("-----------");

            //Console.WriteLine(Factorial(num));
            #endregion


            #region Q8
            //// 8- Create a function named "ChangeChar" to modify a letter in a certain 
            ////    position(0 based) of a string, replacing it with a different letter

            //static string ChangeChar(string text, int i, char c)
            //{
            //    char[] newtext = text.ToCharArray();

            //    newtext[i] = c;

            //    return new string(newtext);
            //}

            //Console.Write("Enter Text : ");
            //string? text = Console.ReadLine();
            //Console.Write("Enter index of text : ");
            //int.TryParse(Console.ReadLine(),out int i);
            //Console.Write("Enter new char : ");
            //char.TryParse(Console.ReadLine(), out char c);
            //Console.WriteLine("------------------");
            //Console.WriteLine(ChangeChar(text,i,c));

            #endregion
        }
    }
}
