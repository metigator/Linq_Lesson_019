using Shared;
using System;
using System.Linq;

namespace CustomLINQMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.Employees;
            //employees.Print("All Employees");

            // Total 100 => 10 Emps / Page = 100 / 10 = 10 Pages

            var page = 2;
            var pageSize = 4;
            // page 1 = Skip(0)
            //var page1 = employees.Skip((page - 1) * pageSize).Take(pageSize);

            var page2x4 = employees.Paginate(page, pageSize);
            page2x4.Print("page #2  [4 emps]");

            var page1x10 = employees.Paginate();
            page1x10.Print("page #1  [10 emps]");

            var page7x10 = employees.Paginate(7);
            page7x10.Print("page #7  [10 emps]");


            var page1x7 = employees.Paginate2(null, 7);
            page1x7.Print("page #1  [7 emps]");

            var page1x7Covered = employees.WhereWithPaginate(x => x.HasHealthInsurance, 1, 7);
            page1x7Covered.Print("page #1  [7 covered emps]");


            var randomEmployee = employees.Random(x => true);
            Console.WriteLine("Random Employee");
            Console.WriteLine(randomEmployee);

            var randomEmployeeWithoutPensionPlan = employees.Random(x => !x.HasPensionPlan);
            Console.WriteLine("Random Employee without pension plan");
            Console.WriteLine(randomEmployeeWithoutPensionPlan);
            Console.ReadKey();
        }
         
    }
}
