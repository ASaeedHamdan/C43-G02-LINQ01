using static Assgiment1.ListGenerator;

namespace Assgiment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Data Setup Test
            //Console.WriteLine(ProductsList[0]);

            //Console.WriteLine(CustomersList[0]);
            #endregion

            #region Restriction Operators

            #region 1. Find all products that are out of stock.
            //var result = ProductsList.Where(p => p.UnitsInStock == 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.

            //var result = ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Returns digits whose name is shorter than their value.

            //string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = digits.Where((D, I) => D.Length < I);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion


            #region Element Operators

            #region 1. Get first Product out of Stock 
            //var result = ProductsList.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(result);
            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result = ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(result);

            #endregion

            #region 3. Retrieve the second number greater than 5 
            //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = arr.Where(n => n > 5).ElementAt(1);
            //Console.WriteLine(result);
            #endregion
            #endregion

            #region Aggregate Operators

            #region 1. Uses Count to get the number of odd numbers in the array
            //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = arr.Count(n => n % 2 != 0);
            //Console.WriteLine(result);
            #endregion

            #region 2. Return a list of customers and how many orders each has.

            //var result = CustomersList.Select(C => new { CustomerID = C.CustomerID, OrderCount = C.Orders.Count() });
            //foreach (var item in result)
            //{
            //Console.WriteLine(item);

            //}

            #endregion

            #region 3. Return a list of categories and how many products each has

            // i search here
            //var categoryProductCounts = ProductsList.GroupBy(p => p.Category)
            //                           .Select(g => new { Category = g.Key, ProductCount = g.Count() });
            //foreach (var item in categoryProductCounts)
            //{
            //    Console.WriteLine(item);

            //}
            #endregion

            #region 4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var total = Arr.Sum();
            //Console.WriteLine(total);
            #endregion

            #region 3.5 Get the total number of characters of all words in dictionary_english.txt
            //var words = File.ReadAllLines("dictionary_english.txt");
            //var totalCharacters = words.Sum(word => word.Length);
            //Console.WriteLine(totalCharacters);
            #endregion

            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var words = File.ReadAllLines("dictionary_english.txt");
            //var result = words.Min(word => word.Length);
            //Console.WriteLine(result);
            #endregion


            #region . Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var words = File.ReadAllLines("dictionary_english.txt");
            //var result = words.Max(word => word.Length);
            //Console.WriteLine(result);
            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var words = File.ReadAllLines("dictionary_english.txt");
            //var result = words.Average(word => word.Length);
            //Console.WriteLine(result);
            #endregion
            #endregion

            #region Ordering Operators


            #region 1. Sort a list of products by name
            //var result = ProductsList.OrderBy(p => p.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedWords = Arr.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in sortedWords)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.
            //var result = ProductsList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.OrderBy(d => d.Length).ThenBy(d => d);
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var result = ProductsList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(w => w.Length).ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Where(d => d.Length > 1 && d[1] == 'i').Reverse();
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion


            #region Transformation Operators

            #region 1. Return a sequence of just the names of a list of products.
            //var result = ProductsList.Select(p => p.ProductName);
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result = words.Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() });
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion


            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var result = ProductsList.Select(p => new { p.ProductName, Price = p.UnitPrice, p.Category });
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region 4. Determine if the value of int in an array matches their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Select((num, index) => num == index);
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var result = from a in numbersA
            //            from b in numbersB
            //            where a < b
            //            select new { A = a, B = b };
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion


            #region 6. Select all orders where the order total is less than 500.00.
            //var result = CustomersList.SelectMany(C => C.Orders).Where(O => O.Total < 500.00M);
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion


            #region 7. Select all orders where the order was made in 1998 or later.
            //var result = CustomersList.SelectMany(C => C.Orders).Where(O => O.OrderDate.Year >= 1998);
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #endregion

            #endregion
        }
    }
}
