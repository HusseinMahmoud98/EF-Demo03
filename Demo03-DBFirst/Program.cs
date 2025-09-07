using Demo03_DBFirst.Data.Contexts;
using Demo03_DBFirst.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Demo03_DBFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext context = new AppDbContext();

            #region DB First
            //Category category = new Category()
            //{
            //    CategoryName = "Hamada",
            //    Description = "Hamada Des"
            //};

            //context.Categories.Add(category);

            //context.SaveChanges();

            //foreach (var item in context.Categories)
            //{
            //    Console.WriteLine(item.CategoryName);
            //} 
            #endregion

            #region Run Sql Query
            #region Run Sql Query [DQL]
            ////Run Sql Query
            //// Select Statments : 1. FromSqlRaw()
            ///                     2. FromSqlInterploated()


            #region 1. FromSqlRaw()
            ////var result = context.Categories.FromSqlRaw("Select* From Categories");
            ////foreach (var item in result)
            ////{
            ////    Console.WriteLine(item.CategoryName);
            ////}


            //var result02 = context.Products.FromSqlRaw("Select* From Products Where UnitsInStock = 0");
            //foreach (var item in result02)
            //{
            //    Console.WriteLine(item.ProductName);
            //}

            #endregion

            #region 2. FromSqlInterploated()
            //int price = 10;
            //var result = context.Products.FromSqlInterpolated($"Select* From Products where UnitPrice > {price}");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.ProductName);
            //} 
            #endregion

            #endregion

            #region Run Sql Query [DML]
            //context.Database.ExecuteSqlRaw("Update Products Set UnitsInStock = 41 Where ProductId = 1");

            //int unitsInStock = 39;
            //context.Database.ExecuteSqlInterpolated($"Update Products Set UnitsInStock = {unitsInStock} Where ProductId = 1");



            #endregion
            #endregion
        }
    }
}
