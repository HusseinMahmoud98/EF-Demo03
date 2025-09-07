using Demo03_InheritanceExample.Contexts;
using Demo03_InheritanceExample.Models;

namespace Demo03_InheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Inheritance Example
            ////3 Ways to generate Schema
            ////1. TPC : Table Per Class
            ////2. TPH : Table Per Hierarchy
            ////3. TPCC : Table Per Concert Class

            //using AppDbContext context = new AppDbContext();

            //List<FullTimeEmployee> fullTimeEmployees = new List<FullTimeEmployee>()
            //{
            //    new FullTimeEmployee
            //    {
            //        Name = "Hisham Ali",
            //        Address = "Cairo",
            //        Email = "Hisam@gmail.com",
            //        Salary = 15000
            //    },

            //     new FullTimeEmployee
            //    {
            //        Name = "Ahmed Ali",
            //        Address = "Cairo",
            //        Email = "ahmed@gmail.com",
            //        Salary = 12000
            //    },

            //      new FullTimeEmployee
            //    {
            //        Name = "Mariam Osama",
            //        Address = "Cairo",
            //        Email = "Mariam@gmail.com",
            //        Salary = 20000
            //    },
            //};

            //context.AddRange(fullTimeEmployees);

            //List<PartTimeEmployee> partTimeEmployees = new List<PartTimeEmployee>()
            //{
            //    new PartTimeEmployee
            //    {
            //        Name = "Hussein Ali",
            //        Address = "Cairo",
            //        Email = "Hisam@gmail.com",
            //        NumberOfHours = 120,
            //        HourRate = 200
            //    },

            //     new PartTimeEmployee
            //    {
            //        Name = "Mahmoud Ali",
            //        Address = "Cairo",
            //        Email = "ahmed@gmail.com",
            //        NumberOfHours = 100,
            //        HourRate = 220
            //    },

            //      new PartTimeEmployee
            //    {
            //        Name = "Fouad Osama",
            //        Address = "Cairo",
            //        Email = "Mariam@gmail.com",
            //        NumberOfHours = 90,
            //        HourRate = 210
            //    },
            //};

            //context.AddRange(partTimeEmployees);

            ////var result = context.Employees.OfType<FullTimeEmployee>();

            ////foreach (var item in result)
            ////{
            ////    Console.WriteLine(item.Name);
            ////}


            //context.SaveChanges();


            //var result = context.FullTimeEmployees.FirstOrDefault(e => e.Id == 1);

            //Console.WriteLine(result.Name); 
            #endregion


        }
    }
}
