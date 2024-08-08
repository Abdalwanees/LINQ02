using Demo.Classes;

namespace Demo
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            #region Transformation (Projection) Select & Selectmany
            ////Select

            /////////////////////////////
            ////Flount syntax
            //var Result=ListGenerator.ProductList.Select(x => x.ProductName);

            ////Quary syntax
            //Result = from x in ListGenerator.ProductList
            //         select x.ProductName;
            //////////////////////////////////
            ////Two categories overloud from select ==>Indexed Select

            //var Result = ListGenerator.ProductList.Where(p=>p.UnitsInStock==0)
            //                                      .Select((p,i) => $"{i} :: {p.ProductName}").ToList();


            /////////////////////////////////////////
            ////Selectmany ==>  selct arrau from arry
            ////Flount syntax
            //var Result = ListGenerator.CustomerList.SelectMany(x => x.Orders);

            ////Quary syntax
            //Result = from i in ListGenerator.CustomerList
            //         from o in i.Orders
            //         where o.Total == 928.75m
            //         select o;

            ///////////////////////////////////
            //// Create annonmoustype 
            ////Flount Select 
            //var Result = ListGenerator.ProductList.Select(p => new { p.ProductID ,p.ProductName });
             ////Quary Select
             //Result=from p in ListGenerator.ProductList
             //       select new { p.ProductID, p.ProductName };
            
            //////////////////////////////////
            ///
            var DiscountList=ListGenerator.ProductList.Where(P=>P.UnitsInStock==0)
                                                        .Select(x=>new 
                                                        {
                                                            ID   =  x.ProductID,
                                                            Name =  x.ProductName, 
                                                            Price=  x.UnitPrice - (x.UnitPrice*.1M) 
                                                        });

            ///////////////////////////////////
            ////Indexed selectedmany
            //var Result = ListGenerator.CustomerList.SelectMany((P, I) => $"{I} :: {P.Orders}");


            foreach (var item in DiscountList)
            {
                Console.WriteLine(item);
            }


            #endregion

        }
    }
}
