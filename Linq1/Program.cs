
using Linq1.Data;
using static Linq1.ListGenerator;
namespace Linq1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            #region Linq start
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> OddNumbers = numbers.Where(num => num % 2 == 1).ToList();
            //foreach (var item in OddNumbers)
            //{
            //    Console.Write($"{item} ");
            //}

            #endregion


            #region Linq Syntax [Fluent , Query]


            #region Fluent Syntax 
            //// 1) static method

            //var OddNumbers = Enumerable.Where(Numbers, x => x % 2 == 1);

            //// 2) Extension Method
            //OddNumbers = Numbers.Where(X => X % 2 == 1);

            //foreach (var number in OddNumbers)
            //{
            //    Console.Write($"{number} ");
            //}

            #endregion


            #region Query Syntax 

            //var EvenNumbers = from N in Numbers where N % 2 == 0 select N;
            //foreach (var item in EvenNumbers)
            //{
            //    Console.Write($"{item} ");
            //}


            #endregion

            #endregion


            #region Excution Ways

            #region Deffered Excution
            //var odd = Numbers.Where(x => x % 2 == 1);
            //foreach (var item in odd)
            //{
            //    Console.Write($"{item} ");
            //}
            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });


            #endregion


            #region  Immediate Excution 
            //var odd = Numbers.Where(x => x % 2 == 1).ToList();
            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });
            //foreach (var item in odd)
            //{
            //    Console.Write($"{item} ");
            //}


            #endregion
            #endregion

            #region Data Setup Test
            //Console.WriteLine(ListGenerator.ProductsList[0]);

            //Console.WriteLine(ListGenerator.CustomersList[0]); 
            #endregion

            #region Filtration [Restrication] Operators - Where 

            #region get products out of stock
            //// get products out of stock
            //// Fluent Syntax ( Extension Method)
            //var result = ProductsList.Where(x => x.UnitsInStock == 0);


            //// Query Syntax
            //result = from P in ProductsList where P.UnitsInStock == 0 select P;
            #endregion


            #region Get Elements In Stock And In Category Of Meat/Poultry 

            // // Fluent Syntax
            // var result = ProductsList.Where(P => P.UnitsInStock > 0 && P.Category == "Meat/Poultry");


            //// Query Syntax

            // result = from P in ProductsList where P.UnitsInStock > 0 && P.Category == "Meat/Poultry" select P;
            #endregion

            #region Indexed Where
            //var result = ProductsList.Where((P, I) => I < 10 && P.UnitsInStock > 100);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}
            #endregion
            #endregion


            #region Transformation [Projection] Operators [Select , Select Many]


            #region Select Product Name
            //// Fluent
            //var result = ProductsList.Select(P => P.ProductName);

            ////Query
            //result = from P in ProductsList select P.ProductName; 
            #endregion


            #region Select Customer Name
            ////Fluent
            //var result = CustomersList.Select(C => C.CustomerName);

            //// Query
            //result = from C in CustomersList select C.CustomerName;
            #endregion

            #region  Select Customer Orders
            ////Fluent
            //var result = CustomersList.SelectMany(C => C.Orders);


            ////Query
            //result = from C in CustomersList
            //         from O in C.Orders
            //         select O;  
            #endregion


            #region Select Product Id and Product Name 
            ////Fluent

            //var result = ProductsList.Select(P => new { ProductID = P.ProductID , ProductName= P.ProductName});

            ////Query

            //result = from P in ProductsList
            //         select new
            //         {
            //             ProductID = P.ProductID,
            //             ProductName = P.ProductName,
            //         };
            #endregion


            #region Select Product In Stock And Apply Discount 10 % On Its Price

            //Fluent
            //var result = ProductsList.Where(P => P.UnitsInStock > 0)
            //    .Select(P => new
            //    {
            //        id = P.ProductID,
            //        name = P.ProductName,
            //        oldprice = P.UnitPrice,
            //        newPrice = P.UnitPrice - (P.UnitPrice * 0.1M)
            //    });

            ////Query

            //result = from P in ProductsList
            //         where P.UnitsInStock > 0
            //         select new
            //         {
            //             id = P.ProductID,
            //             name = P.ProductName,
            //             oldprice = P.UnitPrice,
            //             newPrice = P.UnitPrice - (P.UnitPrice * 0.1M)
            //         };

            #endregion



            #region Ording Operators [Ascending , Descending , Reverse , ThenBy , ThenByDescending]

            #region Get Products Ordered By Price Asc
            //// fluent
            //var result = ProductsList.OrderBy(P => P.UnitPrice);

            //// Query
            //result = from p in ProductsList
            //         orderby p.UnitPrice
            //         select p;
            #endregion

            #region Get Products Ordered By Price Desc
            //// fluent
            // var result = ProductsList.OrderByDescending(P => P.UnitPrice);

            //// Query
            //result = from P in ProductsList 
            //         orderby P.UnitPrice descending
            //         select P;
            #endregion

            #region Get Products Ordered By Price Asc and Number Of Items In Stock

            //// fluent
            //var result = ProductsList.OrderByDescending(P => P.UnitPrice);

            //// Query
            //result = from P in ProductsList
            //         orderby P.UnitPrice descending
            //         select P;
            //#endregion


            //#endregion
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

        }
    }
}
