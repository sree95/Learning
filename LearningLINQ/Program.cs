using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LearningLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            #region BasicLinqOperations
            //ListofCars();

            //InstructorNames();

            //EmployeeHireDate();

            //GettingSystemProcess();

            //QueryTypes();

            //XmlGenerationFormXelement();       

            //QueryXml();

            //QuerySql();

            #endregion

            #region ExtMethods

            //Console.WriteLine(ExtensionMethods.ToDouble("20.53"));

            //string str = "19.83";
            //Console.WriteLine(str.ToDoubleExt());

            //Console.WriteLine(ExtensionMethods.IsZipCodeValid(str));

            //Console.WriteLine(str.IsZipCodeValidExt());

            //PickCityStartsWithLetterL();

            #endregion

            #region LambdaLearning

            Employee[] empArray = new Employee[]
            {
                new Employee {Name ="Scott" , ID = 101 },
                new Employee {Name ="Jira" , ID = 102 },
                new Employee {Name ="Lynch" , ID = 101 }
            };

            Employee scottE = Array.Find(empArray, FindScottPredicate);
            //Console.WriteLine(scottE.ID);

            Employee scottDel = Array.Find(empArray, e => e.Name.Equals("Scott"));

            Console.WriteLine(empArray.Where(e => e.Name == "Scott"));

            //Couple of ways to call

            //Comprehension Query syntax

            IEnumerable<Employee> empList =
                from e in empArray
                where e.Name == "Scott"
                orderby e.ID ascending
                select e;

            // Writing in Extension methods and Lambda exp

            IEnumerable<Employee> empEList = empArray.Where(e => e.Name == "Scott").OrderBy(o => o.ID).Select(e => e);

            //To pick only one employee

            Employee empOne = empArray.Where(e => e.Name == "Scott").First();

            var employee = new
            {
                Name = "Scott",
                Id = 101
            };

            Console.WriteLine(employee.Id);


            //Console.WriteLine(scottDel.ID);

            #endregion

            //ActionsAndFuncs();

            UseExpressions();


        }

        private static void UseExpressions()
        {
            Action printanEmptyLine = () => Console.WriteLine("Hello");

            printanEmptyLine();

            Expression<Action<int>> PrintAnInteger = x => Console.WriteLine(x);

            Action<int, int> PrintTwoIntegers = (x, y) => Console.WriteLine($"{x} and \n {y}");

            

            Action<int> Print = PrintAnInteger.Compile();

            Print(2);

            PrintTwoIntegers(5, 6);

            Func<DateTime> dateTime = () => DateTime.Now;

            Console.WriteLine(dateTime());

            Func<int, int> square = (t) => t * t;

            Func<int, int, int> multiply = (x, y) => x * y;

            Console.WriteLine(multiply(10, 15));
            Console.WriteLine(square(15));

            MovieReviewsDataContext mrdc = new MovieReviewsDataContext();
            IEnumerable<Movie> movies =  mrdc.Movies;

        }

        private static void ActionsAndFuncs()
        {
            Action printanEmptyLine = () => Console.WriteLine("Hello");

            printanEmptyLine();

            Action<int> PrintAnInteger = x => Console.WriteLine(x);

            Action<int, int> PrintTwoIntegers = (x, y) => Console.WriteLine($"{x} and \n {y}");

            PrintAnInteger(2);

            PrintTwoIntegers(5, 6);

            Func<DateTime> dateTime = () => DateTime.Now;

            Console.WriteLine(dateTime());

            Func < int,int> square = t => t * t;

            Func<int, int, int> multiply = (x, y) => x * y;

            Console.WriteLine(multiply(10,15));
            Console.WriteLine(square(15));
        }

        static bool FindScottPredicate(Employee e)
        {
            return e.Name.Equals("Scott");
        }
        

        private static void PickCityStartsWithLetterL()
        {
            string[] str =
            {
                "Boston",
                "London",
                "Los Angels",
                "Hyderabad"
            };

            IEnumerable<string> result = str.Where(e => e.StartsWith("L"));

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }

        }

        private static void QuerySql()
        {
            MovieReviewsDataContext context = new MovieReviewsDataContext();

            IEnumerable<Movie> movies = from dc in context.Movies
                where dc.ReleaseDate.Year >= 2008
                orderby dc.Reviews.Average(x => x.Rating) descending
                select dc;

            foreach (Movie m in movies)
            {
                Console.WriteLine(m.Title);
            }

        }

        private static void XmlGenerationFormXelement()
        {
            XElement element = new XElement("Instructors",
                new XElement("instructor", "Aron"),
                new XElement("instructor", "Finch"),
                new XElement("instructor", "Fritz"),
                new XElement("instructor", "Keith"),
                new XElement("instructor", "Scott")
                );

            Console.WriteLine(element.ToString());
        }

        private static void QueryXml()
        {
            XDocument document = new XDocument(
                new XElement("Processes",
                    from p in Process.GetProcesses()
                    orderby p.ProcessName ascending
                    select new XElement("Process",
                    new XAttribute("Name",p.ProcessName),
                    new XAttribute("ID",p.Id))));

            // 1st way to get inner elements

            //IEnumerable<int> pIdN = from e in document.Element("Processes").Elements("Process")
            //                       select (int)e.Attribute("ID");

            // Another way to get inner elements

            IEnumerable<int> pIdN = from e in document.Descendants("Process")
                where e.Attribute("Name").Value == "devenv"
                orderby (int)e.Attribute("ID") ascending
                select (int)e.Attribute("ID");

            foreach (int id in pIdN)
            {
                Console.WriteLine(id);
            }

        }




        //List of all publi types in the assembly that we are in
        private static void QueryTypes()
        {
            IEnumerable<string> publicTypes = from t in Assembly.GetExecutingAssembly().GetTypes()
                where t.IsPublic
                select t.FullName;

            foreach (var type in publicTypes)
            {
                Console.WriteLine(type);
            }

        }

        private static void GettingSystemProcess()
        {
            IEnumerable<Process> processList = from p in Process.GetProcesses()
                where string.Equals(p.ProcessName, "svchost")
                orderby p.WorkingSet64 descending
                select p;

            foreach (var VARIABLE in processList)
            {
                Console.WriteLine(VARIABLE.ProcessName);
            }
        }

        private static void EmployeeHireDate()
        {
            List<Employee> emp = new List<Employee>()
            {
                new Employee() {ID = 101, Name = "OneEmp", HireDate = new DateTime(2002, 3, 5)},
                new Employee() {ID = 102, Name = "TwoEmp", HireDate = new DateTime(2003, 3, 5)},
                new Employee() {ID = 103, Name = "ThreeEmp", HireDate = new DateTime(2000, 7, 5)},
                new Employee() {ID = 104, Name = "FourEmp", HireDate = new DateTime(2009, 2, 2)},
                new Employee() {ID = 105, Name = "FiveEmp", HireDate = new DateTime(2003, 7, 8)},
                new Employee() {ID = 106, Name = "SixEmp", HireDate = new DateTime(2010, 1, 15)}
            };

            IEnumerable<Employee> emplist = from e in emp
                where e.HireDate.Year >= 2005
                orderby e.ID descending
                select e;



            IEnumerable<int> empLength = from e in emp
                where e.HireDate.Year <= 2005
                orderby e.Name
                select e.Name.Length;            

            foreach (var item in empLength)
            {
                Console.WriteLine(item);
            }

            //foreach (var VARIABLE in emp1)
            //{
            //    Console.WriteLine("ID:" + VARIABLE.ID + " Name: " + VARIABLE.Name + " HireDate:" + VARIABLE.HireDate);
            //}
        }

        private static void InstructorNames()
        {
            string[] instructors = {"Aaron", "Fritz", "Scott", "Keith"};

            IEnumerable<string> query = from instructor in instructors
                where instructor.Length == 5
                orderby instructor descending
                select instructor;

            foreach (string qVariable in query)
            {
                Console.WriteLine(qVariable);
            }
        }

        private static void ListofCars()
        {
            List<Car> listoCars = new List<Car>()
            {
                new Car() {BrandName = "Tayota", OwnerName = "Alex", Model = 1998},
                new Car() {BrandName = "Honda", OwnerName = "Phenix", Model = 2001},
                new Car() {BrandName = "Hundai", OwnerName = "JRD Tata", Model = 1889},
                new Car() {BrandName = "Marithi", OwnerName = "John", Model = 1999},
                new Car() {BrandName = "Audi", OwnerName = "Castelman", Model = 2005}
            };

            IEnumerable<Car> enumerable = from car in listoCars
                select car;
            foreach (var car in enumerable)
            {
                Console.WriteLine(car.OwnerName);
            }
        }
    }

    public class Car
    {
        public string BrandName { get; set; }

        public string OwnerName { get; set; }

        public int Model { get; set; }
    }
}
