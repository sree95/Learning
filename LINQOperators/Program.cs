using LINQOperators;
using LinqQueries;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQOperators
{
    class Program
    {
        protected Program()
        {

        }

        static void Main()
        {
            CallerFunc();                        
        }

        private static void CallerFunc()
        {
            //OfTypeExample();
            //ProcessSorting();
            //SetOperations();
            //SetDistinct();
            //Quantifiers();
            //PrimeNumberCheck();
            //Projection();
            //Joins();
            //GroupNumbers();
            //Grouping();
            //Generation();
            //Range();
            //Repeat();
            //SequenceEquals();
            //ElementOperations();
            //Casting();
            //Concatination();
            //AggregateFunctions();
            Aggregation();


        }

        private static void Aggregation()
        {
            Employee emp = new Employee();

            List<Rule<Employee>> rulesList = new List<Rule<Employee>>()
            {
                new Rule<Employee>() {Test = e => !string.IsNullOrEmpty(e.Name),
                    Message = "Employee name can't be null" },

                new Rule<Employee>() {Test = e => e.DepartmentId > 0 ,
                    Message = "Employee must have assigned a department" },

                new Rule<Employee>() {Test = e => e.Id > 0,
                    Message = "Employee must have an Id"}
            };


            bool isValid = rulesList.All(r => r.Test(emp));

            if (!isValid)
            {
                var failedOnes = rulesList.Where(r => r.Test(emp) == false);

                string errorMessgae = failedOnes.Aggregate(new StringBuilder(),
                    (sb, e) => sb.AppendLine(e.Message),
                    sb => sb.ToString());
                
            }

        }

        private static void AggregateFunctions()
        {
            Process[] processArray = Process.GetProcesses();

            var summary = new
            {
                ProcessCount = processArray.Count(),

                WorkerProcessCount = processArray.Count(x => x.ProcessName == "w3wp"),

                TotalThreads = processArray.Sum(p => p.Threads.Count),

                MinThreads = processArray.Min(m => m.Threads.Count),

                MaxThreads = processArray.Max(m => m.Threads.Count),

                AvgThreads = processArray.Average(a => a.Threads.Count)
            };

            Console.WriteLine(summary.ProcessCount);
            Console.WriteLine(summary.WorkerProcessCount);
            Console.WriteLine(summary.TotalThreads);
            Console.WriteLine(summary.MinThreads);
            Console.WriteLine(summary.MaxThreads);
            Console.WriteLine(summary.AvgThreads);
        }

        private static void Concatination()
        {
            string[] firstNames = { "Sree1", "Sree2", "vasu1", "vasu2" };
            string[] lastNames = { "Sree1", "Sree2", "vasu1", "vasu2" };

            var concat = firstNames.Concat(lastNames).OrderBy(b => b);
            var concat2 = firstNames.Union(lastNames).OrderBy(b => b);

            LoopingwithGenerics(concat);

            LoopingwithGenerics(concat2);
        }

        private static void Casting()
        {
            ArrayList fruitsList = new ArrayList() { "Mango", "Apple", "Grapes" };

            var result = fruitsList.Cast<string>();

            LoopingwithGenerics(result);
        }

        static void ElementOperations()
        {
            string[] empty = { };

            string[] nonEmpty = {"Hello","World"};

            string f = nonEmpty.Single(e => e.StartsWith("H"));

            Console.WriteLine(f);
        }

        private static void SequenceEquals()
        {
            Employee e1 = new Employee() { Id = 1 };
            Employee e2 = new Employee() { Id = 2 };
            Employee e3 = new Employee() { Id = 3 };

            List<Employee> empList1 = new List<Employee>() { e1, e2, e3 };
            List<Employee> empList2 = new List<Employee>() { e3, e2, e1 };

            

            bool result = empList1.SequenceEqual(empList2);

            Console.WriteLine(result);

        }

        private static void Repeat()
        {
            var query = Enumerable.Repeat(10, 10);

            LoopingwithGenerics(query);
        }

        private static void Range()
        {
            var query = Enumerable.Range(1, 500);

            LoopingwithGenerics(query);
        }

        private static void Generation()
        {
            List<Employee> empList = new List<Employee>()
            {
                new Employee {Id =1, DepartmentId =1,Name="Scott" },
                new Employee {Id =2, DepartmentId =1,Name="Poonam" },
                new Employee {Id =3, DepartmentId =2,Name="Andy" },
            };

            var departmentList = new List<Department>()
            {
                new Department {ID = 1,Name ="Engineering" },
                new Department {ID = 2,Name ="Sales" },
                new Department {ID = 3,Name ="Skunkworks" },
            };

            var query = from d in departmentList
                        join e in empList on d.ID equals e.DepartmentId
                        into eg
                        from e in eg.DefaultIfEmpty()
                        select new
                        {
                            DepartmentId = d.Name,
                            Employee = e
                        };

            LoopingwithGenerics(query);
        }

        static void Grouping()
        {
            List<Employee> empList = new List<Employee>()
            {
                new Employee {Id =1, DepartmentId =1,Name="Scott" },
                new Employee {Id =2, DepartmentId =1,Name="Poonam" },
                new Employee {Id =3, DepartmentId =2,Name="Andy" },
            };


            var query = from e in empList
                        group e by e.DepartmentId into eg
                        select new
                        {
                            DepartmentID = eg.Key,
                            Employee = eg
                        };


            var query2 = empList.GroupBy(e => e.DepartmentId);

               
             

            foreach (var item in query)
            {
                Console.WriteLine(item.DepartmentID);


                foreach (var item1 in item.Employee)
                {
                    Console.WriteLine(item1.Name);
                }
            }


            foreach (var item in query2)
            {
                Console.WriteLine(item.Key);

                foreach (var item1 in item)
                {
                    Console.WriteLine(item1.Name);
                }
                
            }

        }

        static void GroupNumbers()
        {
            int[] num = { 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 13, 14, 15 };

            var query = num.GroupBy(i => i % 2 == 0);

            foreach (var item in query)
            {
                Console.WriteLine(item.Key);

                foreach (var item1 in item)
                {
                    Console.WriteLine(item1);
                }

            }
        }

        private static void Joins()
        {
            List<Employee> empList = new List<Employee>()
            {
                new Employee {Id =1, DepartmentId =1,Name="Scott" },
                new Employee {Id =2, DepartmentId =1,Name="Poonam" },
                new Employee {Id =3, DepartmentId =2,Name="Andy" },
            };

            var departmentList = new List<Department>()
            {
                new Department {ID = 1,Name ="Engineering" },
                new Department {ID = 2,Name ="Sales" },
                new Department {ID = 3,Name ="Skunkworks" },
            };

            var query = from d in departmentList
                        join e in empList on d.ID equals e.DepartmentId
                        select new
                        {
                            DepartmentName = d.Name,
                            EmployeeName = e.Name
                        };


            var query2 = departmentList.Join(empList,
                d => d.ID,
                e => e.DepartmentId,
                (d, e) => new
                {
                    DepartmentName = d.Name,
                    EmployeeName = e.Name
                });

            var query3 = departmentList.GroupJoin(empList,
                    d => d.ID,
                    eg => eg.DepartmentId,
                    (d, eg) => new
                    {
                        DepartmentName = d.Name,
                        EmployeeName = eg
                    }
                );


            var query4 = from d in departmentList
                         join e1 in empList on d.ID equals e1.DepartmentId
                          into eg
                         select new
                         {
                             DeparmentName = d.Name,
                             EmployeeObj = eg
                         };


            LoopingwithGenerics(query3);
        }
      
        private static void Projection()
        {
            string[] famousQuotes = 
            {
                "Advertising is legalized laying",
                "Advertising is the greatest art of the twentieth century"
            };

            var query = (from e in famousQuotes from e1 in e.Split(' ') select e1).Distinct();

            var query2 = famousQuotes.SelectMany(e => e.Split(' ')).Distinct();

            LoopingwithGenerics(query2);
            
        }

        private static void PrimeNumberCheck()
        {
            List<int> validPrimePick = new List<int> { 2, 5, 8, 9, 6, 11, 13, 15, 18, 19, 21, 23, 27, 29 };

            //var prime = validPrimePick.Where()
        }

        private static void EvenNumberWithQantifiers()
        {
            List<int> validPrimePick = new List<int> { 2, 5, 8, 9, 6, 11, 13, 15, 18, 19, 21, 23, 27, 29 };

            var even = validPrimePick.Where(e => e % 2 == 0);

            LoopingwithGenerics(even);
        }

        static void Quantifiers()
        {
            Book book = new Book { Auther = "Herman", Name = "Moby Dick" };

            var bookValidationRules = new List<Func<Book, bool>>
            {
                e1 => !string.IsNullOrEmpty(e1.Name),
                e1 => !string.IsNullOrEmpty(e1.Name)
            };

            var isBookValid = bookValidationRules.All(r => r(book));
          
        }

        static void SetDistinct()
        {
            List<Book> book = new List<Book>()
            {
                new Book {Auther = "OneAuther" ,Name = "OneName" },
                new Book {Auther = "TwoAuther" ,Name = "ThreeName" },
                new Book {Auther = "OneAuther" ,Name = "OneName" }
            };

            var query = book
                .Select(b => new
                {
                    b.Auther,
                    b.Name
                })
                .Distinct();

            LoopingwithGenerics(query.Select(c => c.Name));

        }

        static void SetOperations()
        {
            int[] twos = { 2, 4, 6, 8, 10, 12, 14, 16 };
            int[] threes = { 3, 6, 9, 12, 15, 18, 21 };

            //Intersection
            var intersection = twos.Intersect(threes);

            LoopingwithGenerics(intersection);

            //Exception

            var exception = twos.Except(threes);

            LoopingwithGenerics(exception);

            //Union

            var union = twos.Union(threes);

            LoopingwithGenerics(union);

        }

        static void ProcessSorting()
        {
            var query = Process.GetProcesses()
                .OrderBy(p => p.WorkingSet64)
                .ThenByDescending(c => c.Threads.Count);

            LoopingwithGenerics(query);
        }

        static void OfTypeExample()
        {
            IList list = new ArrayList();

            list.Add("Dash");
            list.Add(new object());
            list.Add("Kentaki");
            list.Add(new object());

            IEnumerable query = from aList in list.OfType<string>()
                                select aList;

            LoopingwithoutGenerics(query);

        }

        static void LoopingwithoutGenerics(IEnumerable obj)
        {
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
        }

        static void LoopingwithGenerics<T>(IEnumerable<T> obj)
        {
            foreach (T item in obj)
            {
                Console.WriteLine(item);
            }
        }
    }
}
