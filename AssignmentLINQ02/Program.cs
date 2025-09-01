using AssignmentLINQ01.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Runtime.Intrinsics.X86;
using static AssignmentLINQ01.Data.ListGenerator;
using static System.Net.Mime.MediaTypeNames;
namespace AssignmentLINQ02
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

            #region LINQ - Set Operators 

            #region Q1
            /// 1. Find the unique Category names from Product List

            //var result = ProductList.Select(p => p.Category).Distinct();
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region Q2
            /// 2. Produce a Sequence containing the unique first letter from both product and customer names. 

            //var result = ProductList.Select(p => p.ProductName.First()).Union(CustomerList.Select(p => p.CustomerName.First()));
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region Q3
            /// 3. Create one sequence that contains the common first letter from both product and customer names.

            //var result = ProductList.Select(p => p.ProductName.First()).Intersect(CustomerList.Select(p => p.CustomerName.First()));
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region Q4
            /// 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var result = ProductList.Select(p => p.ProductName.First()).Except(CustomerList.Select(p => p.CustomerName.First()));
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region Q5
            /// 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //var result = ProductList.Select(p => p.ProductName.Substring(p.ProductName.Length - 3)).Concat(CustomerList.Select(p => p.CustomerName.Substring(p.CustomerName.Length - 3)));
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #endregion

            #region LINQ - Quantifiers

            #region Q1
            /// 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            //var text = File.ReadAllLines("dictionary_english.txt");
            //var result = text.Any(t => t.Contains("ei"));
            //Console.WriteLine(result);

            #endregion

            #region Q2
            /// 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //var result = ProductList.Where(p => p.UnitsInStock == 0).Select(p => p).GroupBy(p => p.Category);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var item2 in item)
            //        Console.WriteLine(item2);
            //}

            #endregion

            #region Q3
            /// 3. Return a grouped a list of products only for categories that have all of their products in stock.

            //var result = ProductList.Where(p => p.UnitsInStock > 0).Select(p => p).GroupBy(p => p.Category);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var item2 in item)
            //        Console.WriteLine(item2);
            //}

            #endregion

            #endregion

            #region LINQ – Grouping Operators

            #region Q1
            /// 1. Use group by to partition a list of numbers by their remainder when divided by 5 

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var result = numbers.GroupBy(p => p % 5 );
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"==> {item.Key}");
            //    foreach (var item2 in item)
            //        Console.WriteLine(item2);
            //}

            #endregion

            #region Q2
            /// 2. Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input

            //var text = File.ReadAllLines("dictionary_english.txt");
            //var result = text.GroupBy(p => p.First());
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"==> {item.Key}");
            //    foreach (var item2 in item)
            //        Console.WriteLine(item2);
            //}

            #endregion

            #region Q3
            /// Consider this Array as an Input 
            /// Use Group By with a custom comparer that matches words that are consists of the same Characters Together

            //string[] Arr = { "from", "salt", "earn", " last", "near", "form" };
            //var result = Arr.Select(p => p.Trim()).GroupBy(p=> String.Concat(p.OrderBy(c=>c)));
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"====");
            //    foreach (var item2 in item)
            //        Console.WriteLine(item2);
            //}

            #endregion

            #endregion

        }
    }
}
