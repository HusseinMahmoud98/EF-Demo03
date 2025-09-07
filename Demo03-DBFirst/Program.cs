using Demo03_DBFirst.Data.Contexts;
using Demo03_DBFirst.Data.Model;

namespace Demo03_DBFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext context = new AppDbContext();
            
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
        }
    }
}
