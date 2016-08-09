using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LINQRepeat
{
    class Program
    {
       static Employee[] empArray = new Employee[]
            {
                new Employee {Id = 101,Name ="Scott" },
                new Employee {Id = 102,Name ="Alen" }
            };

        static void Main(string[] args)
        {
            //ArryFind();
            //Actions();

            //Funcs();

            //Expressions();

            PartialClass cls = new PartialClass();
            cls.Created();

        }

        private static void Expressions()
        {
            Expression<Func<int, int, int>> exTry = (x, y) => x * y;
            string str = null;
        }

        private static void Funcs()
        {
            Func<int> fc = () => 10;

            Func<DateTime> dt = () => DateTime.Now;

            Console.WriteLine(dt());

        }

        private static void Actions()
        {
            
            Action act = () => Console.WriteLine("Hello Action");

            Action<int, int, int> PrintThree = (a, b, c) => Console.WriteLine(a + b + c);

            act();
            PrintThree(3,4,5);
        }

        private static void ArryFind()
        {
            Employee emp = Array.Find(empArray, FindingEmployeeScott);

            Console.WriteLine(emp.Name);

            Employee emp2 = Array.Find(empArray,


                //// 1st Stage
                //delegate (Employee e)
                //{
                //    return e.Name == "Scott";
                //});

                ////2nd Stage

                //(Employee e) =>
                //{
                //    return e.Name == "Scott";
                //});


                ////3rd Stage

                //(e) =>
                //{
                //    return e.Name == "Scott";
                //});


                ////4th Stage

                //(e) => e.Name == "Scott");

                //5th Stage

                e => e.Name == "Scott");
        }

        public static bool FindingEmployeeScott(Employee e)
        {
            return e.Name == "Scott";
        }

        public static void DelegateExp()
        {
            Array.Find(empArray, e => e.Id == 102);
        }

    }
}
