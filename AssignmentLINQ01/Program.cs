using AssignmentLINQ01.Data;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using static AssignmentLINQ01.Data.ListGenerator;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AssignmentLINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LINQ - Element Operators

            #region Q1
            /// 1. Get first Product out of Stock  

            //var FPOutOfStouk = ProductList?.FirstOrDefault((p) => p.UnitsInStock == 0 , new Product { ProductName = "No Date"});
            //Console.WriteLine(FPOutOfStouk);

            #endregion

            #region Q2
            /// 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned

            //var FirsPro = ProductList?.FirstOrDefault((p) => p.UnitPrice > 1000, new Product { ProductName = "No Date" , UnitPrice = 0 });
            //Console.WriteLine(FirsPro);
            #endregion

            #region Q3
            /// 3. Retrieve the second number greater than 5  
            /// Int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            ////way01
            //var result = Arr.Where((n) => n > 5)
            //                .Skip(1)
            //                .FirstOrDefault();
            //Console.WriteLine(result);
            ////way02
            //var result02 = Arr.Where((n) => n > 5).ElementAt(1);
            //Console.WriteLine(result02);

            #endregion

            #endregion

            #region LINQ - Aggregate Operators

            #region Q1
            /// 1. Uses Count to get the number of odd numbers in the array 
            ///    Int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Count((n) => n % 2 != 0);
            //Console.WriteLine(result);
            #endregion

            #region Q2
            /// 2. Return a list of customers and how many orders each has.

            //var cusorder = CustomerList?.Select(c => new { Name = c.CustomerName , Orders_Count = c.Orders.Count() });
            //foreach (var item in cusorder)
            //    Console.WriteLine(item);

            #endregion

            #region Q3
            /// 3. Return a list of categories and how many products each has 

            //var cateprod = ProductList?.Select((p) => new { p.Category, Product_count = ProductList?.Count(d => d.Category == p.Category) }).Distinct();
            //foreach (var item in cateprod)
            //    Console.WriteLine(item);

            #endregion

            #region Q4
            /// 4. Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //Console.WriteLine($"Total: {Arr.Sum()}");
            #endregion

            #region Q5
            /// 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First). 

            //var text = File.ReadAllLines("dictionary_english.txt");

            //Console.WriteLine($"Total Characters : {text.Sum(c => c.Length)}");

            #endregion

            #region Q6
            /// 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First). 

            //var text = File.ReadAllLines("dictionary_english.txt");

            //Console.WriteLine($"Total Characters : {text.Min(c => c.Length)}");

            #endregion

            #region Q7
            /// 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First). 

            //var text = File.ReadAllLines("dictionary_english.txt");

            //Console.WriteLine($"Total Characters : {text.Max(c => c.Length)}");

            #endregion

            #region Q8
            /// 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First). 

            //var text = File.ReadAllLines("dictionary_english.txt");

            //Console.WriteLine($"Total Characters : {text.Average(c => c.Length)}");

            #endregion

            #region Q9
            /// 9. Get the total units in stock for each product category.

            //var result = ProductList?.Select((p) => p.Category).Distinct().Select(c=> new {Category = c , Units_IN_Stock = ProductList.Where(n => n.UnitsInStock > 0 && n.Category == c).Sum(p=>p.UnitsInStock) });
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region Q10
            /// 10. Get the cheapest price among each category's products 

            //var result = ProductList.Select(x => x.Category).Distinct().Select(p=> new { Category = p , MIN_Price = ProductList.Where(P => P.Category == p ).Min(p=>p.UnitPrice)});

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region Q11
            /// 11. Get the products with the cheapest price in each category (Use Let)

            //var result =from p in ProductList
            //            group p by p.Category into g
            //            let cheapestPrice = g.Min(x => x.UnitPrice)
            //            from p in g
            //            where p.UnitPrice == cheapestPrice
            //            select new
            //            {
            //                p.Category,
            //                p.ProductName,
            //                p.UnitPrice
            //            };

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region Q12
            /// 12. Get the most expensive price among each category's products. 

            //var result = ProductList.Select(x => x.Category).Distinct().Select(p => new { Category = p, MAX_Price = ProductList.Where(P => P.Category == p).Max(p => p.UnitPrice) });

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region Q13
            /// 13. Get the products with the most expensive price in each category. 

            //var result = ProductList.Select(x => x.Category).Distinct().Select(p => new { Category = p, MaX_Price = ProductList.Where(P => P.Category == p).Max(p => p.UnitPrice), Product_Name = ProductList.Where(y => y.Category == p).Select(n => n.ProductName) });

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region Q14
            /// 14. Get the average price of each category's products. 

            //var result = ProductList.Select(x => x.Category).Distinct().Select(p => new { Category = p, Average_Price = ProductList.Where(P => P.Category == p).Average(p => p.UnitPrice) });

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #endregion

            #region LINQ - Ordering Operators 

            #region Q1
            /// 1. Sort a list of products by name 

            //var result = ProductList.OrderBy(p => p.ProductName);

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region Q2
            /// 2. Uses a custom comparer to do a case-insensitive sort of the words in an array. 

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(x=> x , StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region Q3
            /// 3. Sort a list of products by units in stock from highest to lowest. 

            //var result = ProductList.Where(p => p.UnitsInStock> 0).OrderByDescending(p => p.UnitsInStock );
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region Q4
            /// 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.OrderBy(a => a.Length).ThenBy(a => a);
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region Q5
            /// 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(a => a.Length).ThenBy(a => a, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region Q6
            /// 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var result = ProductList.OrderByDescending(c => c.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region Q7
            /// 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array. 

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderByDescending(x => x.Length).ThenByDescending(y=> y, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region Q8
            /// 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var result = Arr.Where(z => z[1]=='i').Reverse();

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #endregion

            #region LINQ – Transformation Operators 

            #region Q1
            /// 1. Return a sequence of just the names of a list of products.

            //var result = ProductList.Select(p => p.ProductName);
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region Q2
            /// 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array(Anonymous Types).

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var result = words.Select(w => new { Lower = w.ToLower(), Upper = w.ToUpper() });
            //foreach (var word in result)
            //    Console.WriteLine(word);

            #endregion

            #region Q3
            /// 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var result = ProductList.Select(p => new { p.ProductID, p.ProductName, p.Category, p.UnitsInStock, Price = p.UnitPrice });
            //foreach (var item in result) 
            //    Console.WriteLine(item);

            #endregion

            #region Q4
            /// 4. Determine if the value of int in an array matches their position in the array. 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Where((n,i) => n == i);
            //foreach (int n in result) 
            //    Console.WriteLine(n);

            #endregion

            #region Q5
            /// 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = numbersA.SelectMany(a =>  numbersB.Where(b => a < b ).Select(b => $" {a} is less than {b}"));

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region Q6
            /// 6. Select all orders where the order total is less than 500.00.

            //var result = CustomerList.SelectMany(o => o.Orders).Where(p => p.Total < 500);
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region Q7
            /// 7. Select all orders where the order was made in 1998 or later. 

            //var result = CustomerList.SelectMany(o => o.Orders).Where(p => p.OrderDate.Year >= 1998);
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #endregion

        }
    }
}
