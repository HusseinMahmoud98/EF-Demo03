using Demo03.Contexts;
using Demo03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Demo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext context = new AppDbContext();

            #region Introduction to Loading of Navigational Property
            //var departments = new List<Departments>()
            //{ 
            //    new Departments() {Name = "HR"},
            //    new Departments() {Name = "PR"},
            //    new Departments() {Name = "IT"}
            //};

            //var employees = new List<Employees>()
            //{
            //    new Employees() {Name = "Hussein", Address = "Cairo", Age = 29, Salary = 12000, DeptId = 100},
            //    new Employees() {Name = "Mahmoud", Address = "Mansoura", Age = 30, Salary = 15000, DeptId = 300},
            //    new Employees() {Name = "Fouad", Address = "Alex", Age = 33, Salary = 22000, DeptId = 200},
            //};

            //context.Departments.AddRange(departments);
            //context.Employees.AddRange(employees);

            //var employee = context.Employees.FirstOrDefault(e => e.Id == 10);

            //Console.WriteLine(employee?.Id ?? -1);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0.0f);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.HiringDate ?? DateTime.Now);
            //Console.WriteLine(employee?.DeptId ?? -1);
            //Console.WriteLine(employee?.WorkFor?.Name ?? "NA"); //NA

            //var department = context.Departments.FirstOrDefault(e => e.Id == 100);

            //Console.WriteLine(department.Name);

            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //}

            ////Note EF Core dont load navigational property

            //context.SaveChanges(); 
            #endregion

            #region Loading of Navigational Property [Explicit Loading]

            //var employee = context.Employees.FirstOrDefault(e => e.Id == 10);
            ////context.Entry(employee).Reference(nameof(Employees.WorkFor)).Load();
            //context.Entry(employee).Reference(e => e.WorkFor).Load();

            //Console.WriteLine(employee?.Id ?? -1);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0.0f);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.HiringDate ?? DateTime.Now);
            //Console.WriteLine(employee?.DeptId ?? -1);
            //Console.WriteLine(employee?.WorkFor?.Name ?? "NA"); //NA

            //var department = context.Departments.FirstOrDefault(e => e.Id == 100);
            //context.Entry(department).Collection(d => d.Employees).Load();

            //Console.WriteLine(department.Name);

            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //}

            #endregion

            #region Loading of Navigational Property [Eager Loading]

            //var employee = context.Employees.Include(e => e.WorkFor).FirstOrDefault(e => e.Id == 10);

            //Console.WriteLine(employee?.Id ?? -1);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0.0f);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.HiringDate ?? DateTime.Now);
            //Console.WriteLine(employee?.DeptId ?? -1);
            //Console.WriteLine(employee?.WorkFor?.Name ?? "NA"); //HR

            //var department = context.Departments.Include(d => d.Employees).FirstOrDefault(e => e.Id == 100);

            //Console.WriteLine(department.Name);

            #endregion

            #region Loading of Navigational Property [Lazy Loading]
            ////To use lazy loading:
            //// 1. Install package Microsoft.EntityFrameworkCore.Proxies
            //// 2. Update OnConfiguring(), Use UseLazyLoadingProxies(); 
            //// 3. Make All Entities Public
            //// 4. Make All Navigational Properties Virtual

            //var employee = context.Employees.Include(e => e.WorkFor).FirstOrDefault(e => e.Id == 10);

            //Console.WriteLine(employee?.Id ?? -1);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0.0f);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.HiringDate ?? DateTime.Now);
            //Console.WriteLine(employee?.DeptId ?? -1);
            //Console.WriteLine(employee?.WorkFor?.Name ?? "NA"); //HR

            //var department = context.Departments.FirstOrDefault(e => e.Id == 100);

            //Console.WriteLine(department.Name);

            #endregion

            #region LINQ Join Operators - Join
            //// Join Operators - Join
            ////Fluent Syntax
            //var result = context.Employees.Join(context.Departments, e => e.DeptId, d => d.Id,
            //    (e, d) => new
            //    {
            //        EmpId = e.Id,
            //        EmpName = e.Name,
            //        DeptId = d.Id,
            //        DeptName = d.Name
            //    });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            ////Query Expression
            //var result = from e in context.Employees
            //             join d in context.Departments
            //             on e.DeptId equals d.Id
            //             select new
            //             {
            //                 EmpId = e.Id,
            //                 EmpName = e.Name,
            //                 DeptId = d.Id,
            //                 DeptName = d.Name
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Tracking vs No Tracking
            //Tracking vs NoTracking
            #region Tracking
            ////var result = context.Employees.Find(10);
            //var result = context.Employees.FirstOrDefault(e => e.Id == 10);
            //Console.WriteLine(result.Name);

            //Console.WriteLine(context.Entry(result).State); //Unchanged

            //result.Name = "Amir";
            //Console.WriteLine(context.Entry(result).State); //Modified

            //context.SaveChanges();
            //Console.WriteLine(context.Entry(result).State); //Detached 

            #endregion

            #region NoTracking
            //var result = context.Employees.AsNoTracking().FirstOrDefault(e => e.Id == 10);
            //Console.WriteLine(context.Entry(result).State); //Unchanged
            //result.Name = "Ali";

            //Console.WriteLine(context.Entry(result).State); //Detached

            //context.SaveChanges();

            //Console.WriteLine(context.Entry(result).State); //Detached
            #endregion
            #endregion

            #region Local vs Remote
            //Local vs Remote
            #region Local
            context.Employees.Any();
            #endregion

            #region Remote
            context.Employees.Load();
            context.Employees.Local.Any();
            #endregion 
            #endregion

          
        }
    }
}
 