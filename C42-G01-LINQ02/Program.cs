using C42_G01_LINQ02.Classes;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Collections;

namespace C42_G01_LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LINQ - Element Operators

            #region 01 Get first Product out of Stock 

            ////Fluent Syntax
            //var Result = ListGenerator.ProductList.First(p => p.UnitsInStock == 0);
            ////Quary Syntax
            // Result = (from P in ListGenerator.ProductList
            //              where P.UnitsInStock == 0
            //              select P).FirstOrDefault();

            //Console.WriteLine(Result);
            #endregion

            #region 02 Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            ////Fluent syntax
            //var Result = ListGenerator.ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            ////Quary syntax
            //Result = (from p in ListGenerator.ProductList
            //          where p.UnitPrice > 1000
            //          select p).FirstOrDefault();
            //Console.WriteLine(Result != null ? Result.ToString() : "No product found with UnitPrice > 1000");

            #endregion

            #region Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            ////Fluent synatx
            //var Result = Arr.Where(n => n > 5).Skip(1).FirstOrDefault();
            ////Quary syntax
            //Result = (from n in Arr
            //              where n > 5
            //              select n).Skip(1).FirstOrDefault();
            //Console.WriteLine(Result);
            #endregion

            #endregion

            #region LINQ - Aggregate Operators

            #region 01 Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            ////Fluent syntax
            //var Result = Arr.Where(A => A % 2 !=0).Count();

            ////Quary syntax
            //Result= (from I in Arr
            //        where I % 2 != 0
            //        select I).Count();

            //Console.WriteLine($"Count of odd numbers :{Result}");
            #endregion

            #region 2. Return a list of customers and how many orders each has.

            ////Fluent Syntax
            //var Result = ListGenerator.CustomerList.Select(C => new { Id= C.CustomerID,Name =C.CustomerName , orderNumbers = C.Orders.Count() });

            ////Quary syntax
            //Result = from C in ListGenerator.CustomerList
            //         select new 
            //         { 
            //             Id = C.CustomerID,
            //             Name = C.CustomerName, 
            //             orderNumbers = (from O in C.Orders select O.OrderID).Count() };

            //foreach (var Item in Result)
            //{
            //    Console.WriteLine(Item);
            //}
            #endregion

            #region 3. Return a list of categories and how many products each has
            ////Flurnt syntax
            //var Result = ListGenerator.ProductList.GroupBy(C => C.Category).Select(P => new { ProductKey = P.Key, productNumbers = P.Count() });

            ////Quary syntax
            //var Result01= from P in ListGenerator.ProductList
            //        group P by P.Category into G
            //        select new { ProductKey = G.Key, ProductNumbers = G.Count() };

            //Console.WriteLine("Using Fluent");
            //foreach (var Item in Result)
            //{
            //    Console.WriteLine(Item);
            //}
            //Console.WriteLine("Using Quary");
            //foreach (var Item in Result01)
            //{
            //    Console.WriteLine(Item);
            //}
            #endregion

            #region 4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            ////Fluent Syntax
            //var Result = Arr.Sum();

            ////Quary syntax
            //Result =(from A in Arr
            //        select A).Sum();
            //Console.WriteLine($"Result : {Result}");

            #endregion

            #region Readfile ==>dictionary_english.txt
            //string Path = "dictionary_english.txt";
            //string[] Lines = File.ReadAllLines(Path);
            //Console.WriteLine("File read successfully.");


            #region 5.Get the total number of characters of all words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            //// Process words and their lengths
            //var words = Lines.Select(L => new { Word = L, Length = L.Length });
            //Console.WriteLine("Words processed successfully.");

            //// Iterate over each word and display the word and its length
            //foreach (var item in words)
            //{
            //    Console.WriteLine($"Word: {item.Word}, Length: {item.Length}");
            //}
            #endregion

            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var shortWord = Lines.Min(L => L.Length);
            //shortWord = (from word in Lines select word.Length).Min();
            //Console.WriteLine($"Shortest Word Length: {shortWord}");

            #endregion

            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var longWord = Lines.Max(L => L.Length);
            //longWord = (from word in Lines select word.Length).Max();
            //Console.WriteLine($"Longest Word Length: {longWord}");

            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt 
            //var avgWord = Lines.Average(L => L.Length);
            //avgWord = (from word in Lines select word.Length).Average();
            //Console.WriteLine($"Average Word Length (Query Syntax): {avgWord}");
            #endregion



            #endregion

            #region 9. Get the total units in stock for each product category

            ////Fluent syntax
            //var Result = ListGenerator.ProductList.GroupBy(P => P.Category)
            //                                             .Select(C => new
            //                                             {
            //                                                 Category = C.Key,
            //                                                 UnitsInStock = C.Sum(p => p.UnitsInStock)
            //                                             });
            ////Quary Syntax
            //Result = from product in ListGenerator.ProductList
            //            group product by product.Category into productGroup
            //            select new
            //            {
            //                Category = productGroup.Key,
            //                UnitsInStock = productGroup.Sum(p => p.UnitsInStock)
            //            };
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Total Units in Stock: {item.UnitsInStock}");
            //}

            #endregion

            #region 10. Get the cheapest price among each category's products
            ////Fluent syntax
            //var Result = ListGenerator.ProductList.GroupBy(P => P.Category)
            //                                            .Select(C => new
            //                                            {
            //                                                Category = C.Key,
            //                                                CheapestPrice = C.Min(P => P.UnitPrice)
            //                                            });
            ////Quary syntax
            //Result = from product in ListGenerator.ProductList
            //         group product by product.Category into productGroup
            //         select new
            //         {
            //             Category = productGroup.Key,
            //             CheapestPrice = productGroup.Min(P => P.UnitPrice)
            //         };


            //foreach (var price in Result)
            //{
            //    Console.WriteLine($"Category: {price.Category}, Cheapest Price: {price.CheapestPrice}");
            //}
            #endregion

            #region 11. Get the products with the cheapest price in each category (Use Let)

            //var Result = from P in ListGenerator.ProductList
            //                    group P by P.Category into C
            //                    let CheapProduct = C.OrderBy(p => p.UnitPrice).FirstOrDefault()
            //                    select new
            //                    {
            //                        Category = C.Key,
            //                        CheapProduct = CheapProduct
            //                    };

            //foreach (var price in Result)
            //{
            //    Console.WriteLine($"Category: {price.Category}, Product: {price.CheapProduct?.ProductName}, Price: {price.CheapProduct?.UnitPrice}");
            //}


            #endregion

            #region 12. Get the most expensive price among each category's products

            //var Result =from product in ListGenerator.ProductList
            //                         group product by product.Category into productGroup
            //                         select new
            //                         {
            //                             Category = productGroup.Key,
            //                             ExpensivePrice = productGroup.Max(p => p.UnitPrice)
            //                         };

            //foreach (var expensive in Result)
            //{
            //    Console.WriteLine($"Category: {expensive.Category}, Most Expensive Price: {expensive.ExpensivePrice}");
            //}

            #endregion

            #region 13. Get the products with the most expensive price in each category.

            //var Result = from P in ListGenerator.ProductList
            //                     group P by P.Category into E
            //                     let ExpensiveProduct = E.OrderByDescending(p => p.UnitPrice).FirstOrDefault()
            //                     select new
            //                     {
            //                         Category = E.Key,
            //                         ExpensiveProduct = ExpensiveProduct
            //                     };

            //foreach (var expensive in Result)
            //{
            //    Console.WriteLine($"Category: {expensive.Category}, Product: {expensive.ExpensiveProduct?.ProductName}, Price: {expensive.ExpensiveProduct?.UnitPrice}");
            //}

            #endregion

            #region 14. Get the average price of each category's products.

            //var Result = ListGenerator.ProductList.GroupBy(P => P.Category)
            //                                       .Select(C => new
            //                                       {
            //                                           Category = C.Key,
            //                                           AveragePrice = C.Average(p => p.UnitPrice)
            //                                       });

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Average Price: {item.AveragePrice}");
            //}
            #endregion

            #endregion

            #region LINQ - Set Operators

            #region 1. Find the unique Category names from Product List

            //var Result = ListGenerator.ProductList.Select(p => p.Category)
            //                                              .Distinct();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.

            //var list1 = ListGenerator.ProductList.Select(P => P.ProductName[0]);
            //var list2 = ListGenerator.CustomerList.Select(C => C.CustomerName[0]);
            //var Result = list1.Union(list2);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3. Create one sequence that contains the common first letter from both product and customer names.
            //var list1 = ListGenerator.ProductList.Select(P => P.ProductName[0]);
            //var list2 = ListGenerator.CustomerList.Select(C => C.CustomerName[0]);
            //var Result = list1.Intersect(list2);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            // }
            #endregion

            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var list1 = ListGenerator.ProductList.Select(P => P.ProductName[0]);
            //var list2 = ListGenerator.CustomerList.Select(C => C.CustomerName[0]);
            //var Result = list1.Except(list2);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //var list3 = ListGenerator.ProductList.Select(P => P.ProductName.Length >= 3 ? P.ProductName.Substring(P.ProductName.Length - 3) : P.ProductName);
            //var list4 = ListGenerator.CustomerList.Select(C => C.CustomerName.Length >= 3 ? C.CustomerName.Substring(C.CustomerName.Length - 3) : C.CustomerName);
            //var Result = list3.Concat(list4);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion


            #endregion

            #region LINQ - Partitioning Operators

            #region 1. Get the first 3 orders from customers in Washington

            //var Result = ListGenerator.CustomerList.Where(C => C.Region == "WA").SelectMany(C => C.Orders).Take(3); ;

            //Result = (from c in ListGenerator.CustomerList
            //          where c.Region == "WA"
            //          from o in c.Orders
            //          select o).Take(3);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington.

            //var Result = ListGenerator.CustomerList.Where(C => C.Region == "WA").SelectMany(C => C.Orders).Skip(2); ;

            //Result = (from c in ListGenerator.CustomerList
            //          where c.Region == "WA"
            //          from o in c.Orders
            //          select o).Skip(2);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers.TakeWhile((v, i) => v > i);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers.Where(i => i % 3 == 0 && i != 0);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 5. Get the elements of the array starting from the first element less than its position.

            //int[] nums = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = nums.SkipWhile((v, i) => v >= i);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion

            #region LINQ - Quantifiers

            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //string Path = "dictionary_english.txt";
            //string[] Lines = File.ReadAllLines(Path);
            //Console.WriteLine("File read successfully.");
            //var words = Lines.Any(l => l.Contains("ei"));
            //Console.WriteLine(words);

            #endregion

            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //var Result = ListGenerator.ProductList.GroupBy(p => p.Category).Where(I => I.Count(p => p.UnitsInStock == 0) > 0);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //    foreach (var prod in item)
            //        Console.WriteLine(prod);
            //}

            #endregion

            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.
            //var result = from p in ListGenerator.ProductList
            //             group p by p.Category into g
            //             where g.All(p => p.UnitsInStock > 0)
            //             select g;
            //result = ListGenerator.ProductList.GroupBy(p => p.Category)
            //                                  .Where(g => g.All(p => p.UnitsInStock > 0));
            //foreach (var category in result)
            //{
            //    Console.WriteLine(category.Key);
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine(product);
            //    }
            //}


            #endregion

            #endregion

            #region LINQ – Grouping Operators

            #region 1. Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var Result = numbers.GroupBy(n => n % 5);


            //Result = from n in numbers
            //               group n by n % 5 into g
            //               select g;
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"remainder of {item.Key} when divided by 5:");
            //    foreach (var number in item)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            #endregion

            #region 2. Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input

            ////var Lines = System.IO.File.ReadAllLines("dictionary_english.txt");
            ////var Result = Lines.GroupBy(l => l[0]);
            ////Result = from l in Lines
            ////         group l by l[0] into g
            ////         select g;

            ////foreach (var item in Result)
            ////{
            ////    foreach (var word in item)
            ////    {
            ////        Console.WriteLine(word);
            ////    }
            ////}


            #endregion

            #region MyRegion
            string[] arr = { "from", "salt", "earn", "last", "near", "form" };
            var groupedWords = arr
            .GroupBy(word => new string(word.OrderBy(c => c).ToArray()));

            groupedWords = from word in arr
                           group word by new string(word.OrderBy(c => c).ToArray()) into g
                           select g;

            foreach (var group in groupedWords)
            {
                Console.WriteLine($"....");
                foreach (var word in group)
                {
                    Console.WriteLine(word);
                }
            }
            #endregion

            #endregion
        }
    }
}
