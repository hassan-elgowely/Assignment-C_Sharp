using System.Collections.Generic;
using System.Globalization;
using System.Security.Claims;
using System.Security.Principal;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q19
            // 19- . Write a program that prints an identity matrix using for loop, in 
            //       other words takes a value n from the user and shows the identity table ofsize n* n.



            //bool flag;
            //int n;
            //do
            //{
            //    Console.Write("Enter number : ");
            //    flag = int.TryParse(Console.ReadLine(), out n);
            //} while (!flag);
            //int[,] num = new int[n,n];

            //for (int i = 0; i < num.GetLength(0); i++) 
            //{
            //    for (int j = 0; j < num.GetLength(1); j++) 
            //    {
            //        Console.Write((i == j) ? 1 : 0);
            //    }
            //    Console.WriteLine();
            //}

            #endregion


            #region Q20
            // 20- Write a program in C# Sharp to find the sum of all elements of the array.



            //int sum = 0 , index;
            //bool IndexIsParse , ArrayIsParse;
            //do
            //{
            //    Console.WriteLine("Enter the length of array");
            //    IndexIsParse = int.TryParse(Console.ReadLine(), out index);
            //}   while (!IndexIsParse);

            //int[] numbers = new int[index];


            //for (int i = 0; i < index; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine("Enter Numbers");
            //        ArrayIsParse = int.TryParse(Console.ReadLine(), out numbers[i]);
            //    }   while (!ArrayIsParse);


            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            #endregion


            #region Q21
            // 21- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.


            //int index;
            //bool IndexIsParse, ArrayIsParse01 , ArrayIsParse02;
            //do
            //{
            //    Console.WriteLine("Enter the length of 2 array");
            //    IndexIsParse = int.TryParse(Console.ReadLine(), out index);
            //} while (!IndexIsParse);

            //int[] numbers01 = new int[index];
            //int[] numbers02 = new int[index];



            //for (int i = 0; i < index; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine("Enter Numbers of arr01 : ");
            //        ArrayIsParse01 = int.TryParse(Console.ReadLine(), out numbers01[i]);
            //    } while (!ArrayIsParse01);


            //}
            //for (int i = 0; i < index; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine("Enter Numbers of arr02 : ");
            //        ArrayIsParse02 = int.TryParse(Console.ReadLine(), out numbers02[i]);
            //    } while (!ArrayIsParse02);


            //}
            //int[] merge = numbers01.Concat(numbers02).ToArray();
            //Array.Sort(merge);
            //for (int i = 0; i < merge.Length; i++)
            //{
            //    Console.WriteLine(merge[i]);
            //}

            #endregion


            #region Q22
            // 22- Write a program in C# Sharp to count the frequency of each element of an array. 


            //int index;
            //bool IndexIsParse, ArrayIsParse;
            //do
            //{
            //    Console.WriteLine("Enter the length of array");
            //    IndexIsParse = int.TryParse(Console.ReadLine(), out index);
            //} while (!IndexIsParse);

            //int[] numbers = new int[index];


            //for (int i = 0; i < index; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine("Enter Numbers");
            //        ArrayIsParse = int.TryParse(Console.ReadLine(), out numbers[i]);
            //    } while (!ArrayIsParse);

            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{ 
            //    bool same = false;
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (numbers[i] == numbers[j])
            //        {
            //            same = true;
            //            break;

            //        }
            //    }
            //    int x = 1;
            //    if (same)
            //        continue;

            //    for (int s = i + 1; s < numbers.Length; s++)
            //    {
            //        if (numbers[s] == numbers[i])
            //            x++;
            //    }
            //    Console.WriteLine($" {numbers[i]} ===>  {x}");
            //}





            #endregion


            #region Q23
            // 23- Write a program in C# Sharp to find maximum and minimum element in an array


            //int index;
            //bool IndexIsParse, ArrayIsParse;
            //do
            //{
            //    Console.WriteLine("Enter the length of array");
            //    IndexIsParse = int.TryParse(Console.ReadLine(), out index);
            //} while (!IndexIsParse);

            //int[] numbers = new int[index];


            //for (int i = 0; i < index; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine("Enter Numbers");
            //        ArrayIsParse = int.TryParse(Console.ReadLine(), out numbers[i]);
            //    } while (!ArrayIsParse);

            //}
            //int max =  numbers[0];
            //int min =  numbers[0];
            //for (int i = 0;i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max) 
            //    {
            //        max = numbers[i];
            //    }
            //    if (numbers[i] < min)
            //    { 
            //        min = numbers[i];    
            //    }
            //}
            //Console.WriteLine($"max ===>  {max}");
            //Console.WriteLine($"min ===>  {min}");

            #endregion


            #region Q24
            //  24- Write a program in C# Sharp to find the second largest element in an array .


            //int index;
            //bool IndexIsParse, ArrayIsParse;
            //do
            //{
            //    Console.WriteLine("Enter the length of array");
            //    IndexIsParse = int.TryParse(Console.ReadLine(), out index);
            //} while (!IndexIsParse);

            //int[] numbers = new int[index];


            //for (int i = 0; i < index; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine("Enter Numbers");
            //        ArrayIsParse = int.TryParse(Console.ReadLine(), out numbers[i]);
            //    } while (!ArrayIsParse);

            //}
            //int max = numbers[0];
            //int max2 = numbers[0];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        max2 = max;
            //        max = numbers[i];
            //    }
            //    else
            //    { 
            //        max2 = numbers[i];
            //    }

            //}
            //Console.WriteLine($"second max ===>  {max2}");

            #endregion


            #region Q25
            // 25 Consider an Array of Integer values with size N, having values as in this Example


            //int index;
            //bool IndexIsParse, ArrayIsParse;
            //do
            //{
            //    Console.WriteLine("Enter the length of array");
            //    IndexIsParse = int.TryParse(Console.ReadLine(), out index);
            //} while (!IndexIsParse);

            //int[] numbers = new int[index];


            //for (int i = 0; i < index; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine("Enter Numbers");
            //        ArrayIsParse = int.TryParse(Console.ReadLine(), out numbers[i]);
            //    } while (!ArrayIsParse);

            //}

            //int maxlong = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = i + 1; j < numbers.Length; j++)
            //    { 
            //        if (numbers[i] == numbers[j])
            //        {
            //            int l = j - i - 1;
            //            if (l >maxlong)
            //               maxlong = l;

            //        }
            //    }
            //}
            //Console.WriteLine($"maxlong : {maxlong}");

            #endregion


            #region Q26
            // 26. Given a list of space separated words, reverse the order of the words.
            //     Input: this is a test 
            //     Input: all your base
            //     Input: Word
            //     Note :  
            //     Output: test a is this
            //     Output: base your all
            //     Output: Word
            //     Check the Split Function(Member in String Class) Output will be a Single
            //     Console.WriteLine Statement


            //Console.WriteLine("Enter text : ");
            //string text = Console.ReadLine();
            //string[] arr = text.Split();

            //string reservetext= "";
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    reservetext += arr[i];
            //}
            //Console.WriteLine(reservetext);


            #endregion


            #region Q27
            // 27- Write a program to create two multidimensional arrays of same size. 
            //     Accept value from user and store them in first array. Now copy all the
            //     elements of first array on second array and print second array.


            //int[,] x = new int[2, 2];
            //int[,] y = new int[2, 2];

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    { 
            //    Console.WriteLine("enter numbers : ");
            //        x[i, j] = int.Parse(Console.ReadLine());
            //    }

            //}
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        y[i, j] = x[i,j];
            //    }

            //}
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.WriteLine(y[i,j]);
            //    }

            //}

            #endregion


            #region Q28
            // 28- Write a Program to Print One Dimensional Array in Reverse Order 


            //int index;
            //bool IndexIsParse, ArrayIsParse;
            //do
            //{
            //    Console.WriteLine("Enter the length of array");
            //    IndexIsParse = int.TryParse(Console.ReadLine(), out index);
            //} while (!IndexIsParse);

            //int[] numbers = new int[index];


            //for (int i = 0; i < index; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine("Enter Numbers");
            //        ArrayIsParse = int.TryParse(Console.ReadLine(), out numbers[i]);
            //    } while (!ArrayIsParse);

            //}

            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

        }
    }
}
