using System.Collections;
using System.Drawing;
using System.Numerics;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AssignmentADV02
{
    internal class Program
    {
        #region Q1 FN
        public static void ReversFN(ArrayList array)
        {
            if (array != null)
            {
                for (int i = array.Count - 1; i >= 0; i--)
                {
                    Console.Write($"{array[i]}  ");
                }
            }
        }
        // other way
        public static void ReversFN02(ArrayList array)
        {
            if (array != null)
            {
                int x = 0;
                int y = array.Count - 1;
                while (x < y)
                {
                    var temp = array[x];
                    array[x] = array[y];
                    array[y] = temp;
                    x++;
                    y--;
                }
            }
        }
        #endregion

        #region Q6 FN
        public static void RemoveDuplication<T>(T[] array)
        {
            if (array != null)
            {
                List<T> newarray = new List<T>();
                foreach (T t in array)
                {
                    if (!newarray.Contains(t))
                        newarray.Add(t);
                }
                foreach (T t in newarray)
                    Console.WriteLine(t);
            }
        }
        #endregion

        #region Q7 FN
        public static void RemoveOdd(ArrayList array)
        {
            if (array != null)
            {
                List<int> newarray = new List<int>();
                for (int i = 0; i <= array.Count;i++ )
                {
                    if (i % 2 == 0)
                    {
                        newarray.Add(i);
                    }
                }
                foreach (var t in newarray)
                    Console.WriteLine(t);
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region Q1
            ///1. You are given an ArrayList containing a sequence of elements. try to
            ///   reverse the order of elements in the ArrayList in-place(in the same
            ///   arrayList) without using the built-in Reverse.Implement a function that
            ///   takes the ArrayList as input and modifies it to have the reversed order ofelements.


            //ArrayList numbers = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //ReversFN(numbers);
            //Console.WriteLine("\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            //ArrayList numbers02 = new ArrayList() { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            //ReversFN02(numbers02);
            //foreach (var i in numbers02) 
            //    Console.Write($"{i}  ");
            #endregion

            #region Q2
            /// 2.You are given a list of integers. Your task is to find and return a new list
            ///   containing only the even numbers from the given list.

            //List<int> numbers = new List<int>() { 11, 22, 33, 44, 55, 66, 77, 88, 99 };

            //List<int> evenNum = new List<int>();
            //evenNum = numbers.FindAll((n) => n % 2 == 0);
            //foreach (int i in evenNum)
            //    Console.Write($"{i} ");
            #endregion

            #region Q3
            /// 3.implement a custom list called FixedSizeList<T> with a predetermined
            ///   capacity.This list should not allow more elements than its capacity and
            ///   should provide clear messages if one tries to exceed it or access invalid indices.
            ///   
            ///   Requirements: 
            ///   1.Create a generic class named FixedSizeList<T>.
            ///   2. Implement a constructor that takes the fixed capacity of the list as a parameter.
            ///   3.Implement an Add method that adds an element to the list, but throws an exception if the list is already full. 
            ///   4.Implement a Get method that retrieves an element at a specific index in the list but throws an exception for invalid indices.

            //FixedSizeList<int> num = new FixedSizeList<int>(7);
            //num.Add(100);
            //num.Add(200);
            //num.Add(300);
            //num.Add(400);
            //num.Add(500);
            //num.Add(600);
            //num.Add(700);
            //num.Add(800);
            //Console.WriteLine(num.Get(5));
            //Console.WriteLine(num.Get(10));

            #endregion

            #region Q4
            /// 4.Given an array  consists of  numbers with size N and number of queries, in 
            ///   each query you will be given an integer X, and you should print how many
            ///   numbers in array that is greater than  X.
            ///   Ex: 
            ///   Input
            ///   3 3                //Size of array , number of queries 
            ///   11 5 3             //Array  
            ///   1                  //Query1 
            ///   5                  //Query2 
            ///   13                 //Query3 
            ///   Output
            ///   3                  //11,5,3 
            ///   1                  //11 
            ///   0

            //int n;
            //Console.Write("Enter Size : ");
            //int.TryParse(Console.ReadLine(), out n);
            //int[] array = new int[n];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write($"Enter Element 0{i+1} : ");
            //    int.TryParse (Console.ReadLine(), out array[i]);
            //}
            //Console.Clear();
            //int q;
            //Console.Write("Enter Number of Queries : ");
            //int.TryParse(Console.ReadLine(), out q);
            //for (int i = 0; i < q; i++)
            //{
            //    Console.Write($"Enter Query 0{i + 1} : ");
            //    int x;
            //    int.TryParse(Console.ReadLine(), out x);

            //    int count = 0;
            //    foreach (int num in array)
            //    {
            //        if (num > x)
            //            count++;
            //    }
            //    Console.WriteLine($" {x} : {count} ");
            //}

            #endregion

            #region Q5
            /// 5.Given a number N and an array of N numbers.Determine if it's palindrome or not. 
            ///   Ex:
            ///   Input:
            ///   5
            ///   1 3 2 3 1
            ///   Output:
            ///   YES

            //int n;
            //Console.Write("Enter Size : ");
            //int.TryParse(Console.ReadLine(), out n);
            //int[] array = new int[n];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write($"Enter Element 0{i + 1} : ");
            //    int.TryParse(Console.ReadLine(), out array[i]);
            //}
            //Console.Clear();

            //int left = 0;
            //int right =array.Length -1;
            //bool palindrome = true;
            //while (left < right)
            //{
            //    if (array[left] != array[right])
            //    {
            //        palindrome = false;
            //        break;
            //    }
            //    left++;
            //    right--;
            //}
            //if (palindrome)
            //    Console.WriteLine("yes");
            //else
            //    Console.WriteLine("no");

            #endregion

            #region Q6
            /// 6. Given an array, implement a function to remove duplicate elements from an array. 

            //int[] numbers = { 10, 2, 5, 4, 10, 2, 3, 4, 5 };
            //RemoveDuplication(numbers);
            #endregion

            #region Q7
            /// 7.  Given an array list , implement a function to remove all odd numbers from it.
            
            //ArrayList numbers = new ArrayList() {1,2,3,4,5,6,7,8,9,10 };

            //RemoveOdd(numbers);

            #endregion
        }
    }
}
