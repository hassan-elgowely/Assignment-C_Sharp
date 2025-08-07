using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace AssignmentADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            /// 1.The Bubble Sort algorithm has a time complexity of O(n ^ 2) in its worst
            ///   and average cases, which makes it inefficient for large datasets. How we
            ///   can optimize the Bubble Sort algorithm
            ///   And implement the code of this optimized bubble sort algorithm


            //int[] a = { 7, 1, 4, 85, 9, 55, 75, 98, 9, 956, 6, 1, 2, };

            //Stopwatch swNormal = Stopwatch.StartNew();
            //EnhanceBubbleSort<int>.BubbleSort(a);
            //swNormal.Stop();


            //foreach (var i in a)
            //    Console.Write($"{i} ");


            //Console.WriteLine($"\nTime : {swNormal}");

            //Console.WriteLine("**********************");

            //Stopwatch swEnhance = Stopwatch.StartNew();
            //EnhanceBubbleSort<int>.EnhancedBubbleSort(a);
            //swEnhance.Stop();


            //foreach (var i in a)
            //    Console.Write($"{i} ");


            //Console.WriteLine($"\nTime after Enhnace : {swEnhance}"); 

            #endregion

            #region Q2
            /// 2.create a generic Range < T > class that represents a range of values from a
            ///   minimum value to a maximum value.The range should support basic
            ///   operations such as checking if a value is within the range and
            ///   determining the length of the range.
            ///   Requirements: 
            ///   1. Create a generic class named Range<T> where T represents the type
            ///   of values.
            ///   2. Implement a constructor that takes the minimum and maximum
            ///   values to define the range. 
            ///   3. Implement a method IsInRange(T value) that returns true if the given
            ///   value is within the range, otherwise false. 
            ///   4. Implement a method Length() that returns the length of the range
            ///   (the difference between the maximum and minimum values). 
            ///   5. Note: You can assume that the type T used in the Range<T> class
            ///   implements the IComparable<T> interface to allow for comparisons.
            
            
            //Range<decimal> range = new Range<decimal>(1,100);

            //Console.WriteLine(range.IsInRange(50));
            //Console.WriteLine(range.IsInRange(150));

            //Console.WriteLine(range.Length());
            #endregion

        }
    }
}
