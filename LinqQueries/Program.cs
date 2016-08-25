using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeExtensionsGood;
using System.Linq.Expressions;
using System.Linq.Dynamic;

namespace LinqQueries
{
    class Program
    {
        static void Main()
        {
            //SimpleEmployeeQueries();

            //UseTheLetKeyword();
            //UseTheIntoKeyword();
            //UseGroup();
            //USeJoin();
            //UseComposition();
            //UseDynamicQuery();
            //UseDynamicQueryfromSystemLinqDynamicDynamicQueriable();
        }

        static void UseDynamicQueryfromSystemLinqDynamicDynamicQueriable()
        {
            var repository = new EmployeeRepository().GetAll();

            var query = repository.AsQueryable()
                .OrderBy("Name").Where("DepartmentId = 1");

            Write(query);
        }

        static void UseDynamicQuery()
        {
            var repository = new EmployeeRepository();

            string field = "Name";

            var parameter = Expression.Parameter(typeof(Employee), "e");

            var getter = Expression.Property(parameter, typeof(Employee).GetProperty(field));

            var lambda = Expression.Lambda<Func<Employee, string>>(getter, parameter);

            var employee = repository.GetAll().OrderBy(lambda.Compile());
        }

        static void UseComposition()
        {
            var repository = new EmployeeRepository();

            var query = from emp in repository.GetDepartmentById(1)
                        where emp.Name.Length < 6
                        select emp;            
        }
       

        static void USeJoin()
        {
            var employeeRepository = new EmployeeRepository();

            var depatmentRepository = new DepartmentRepository();


            var query = from emp in employeeRepository.GetAll()
                        join d in depatmentRepository.GetAll()
                        on emp.DepartmentId equals d.ID
                        select new
                        {
                            Employee = emp.Name,
                            Department = d.Name
                        };

            var query2 = from d in depatmentRepository.GetAll()
                         join emp in employeeRepository.GetAll()
                         on d.ID equals emp.DepartmentId
                            into gid
                         select new
                         {
                             Department = d.Name,
                             Employee = gid
                         };



            foreach (var item in query2)
            {
                Console.WriteLine(item.Department);
                foreach (var item2 in item.Employee)
                {
                    Console.WriteLine(item2.Name);
                }
            }


            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.Employee);
            //    Console.WriteLine(item.Department);
            //}

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

        static void UseTheLetKeyword()
        {
            var repository = new EmployeeRepository();

            var query =
                from e in repository.GetAll()
                let lName = e.Name.ToLower()
                where lName == "Scott"
                select lName;
        }

        static void SimpleEmployeeQueries()
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
