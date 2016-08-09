using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeExtensionsGood;

namespace LinqQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleEmployeeQueries();

            UseTheLetKeyword();
            UseTheIntoKeyword();
            UseGroup();
        }

        static void UseGroup()
        {
            var repository = new EmployeeRepository();

            var groping = from emp in repository.GetAll()
                          group emp by emp.DepartmentId
                            into gr
                          orderby gr.Key descending
                          where gr.Key < 3
                          select new
                          {
                              DeparmentID = gr.Key,
                              Count = gr.Count(),
                              Employee = gr
                          };

            var extGrouping = repository.GetAll().GroupBy(e => e.DepartmentId).OrderByDescending(e => e.Key).Where(e => e.Key < 3).Select(x => new
            {
                DepartmentId = x.Key,
                Count = x.Count()
            });

            foreach (var range in extGrouping)
            {
                Console.WriteLine(range.DepartmentId);
                Console.WriteLine(range.Count);
            }


            //foreach (var item in groping)
            //{
            //    Console.WriteLine(item.DeparmentID);
            //    Console.WriteLine(item.Count);

            //    foreach (var item1 in item.Employee)
            //    {
            //        Console.WriteLine($"Employee Name {item1.Name} and Id is {item1.Id}");
            //    }
            //}
        }

        private static void UseTheIntoKeyword()
        {
            var repository = new EmployeeRepository();

            var query = from e in repository.GetAll()
                        where e.Name.StartsWith("p")
                        select e
                            into e1
                        where e1.Name.Length < 5
                        select e1;


        }

        private static void UseTheLetKeyword()
        {
            var repository = new EmployeeRepository();

            var query =
                from e in repository.GetAll()
                let lName = e.Name.ToLower()
                where lName == "Scott"
                select lName;
        }

        private static void SimpleEmployeeQueries()
        {
            EmployeeRepository repository = new EmployeeRepository();

            var query1 = (from e in repository.GetAll()
                          where e.DepartmentId < 3 && e.Id < 10
                          orderby e.DepartmentId descending
                          orderby e.Name ascending
                          select e).ToList();

            var query2 = repository.GetAll().Where(d => d.DepartmentId < 3 && d.Id < 10).OrderByDescending(d => d.DepartmentId).OrderBy(n => n.Name);

            Write(query1);

            repository.AddEmployee(new Employee { DepartmentId = 2, Id = 7, Name = "SreeSeven" });

            Write(query1);

            Write(query2);
        }

        static void Write(IEnumerable<Employee> emplist)
        {
            foreach (var item in emplist)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine();
        }
    }


}
