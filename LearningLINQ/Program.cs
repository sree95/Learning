using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //List <Car> listoCars = new List<Car>()
            //{
            //    new Car() { BrandName = "Tayota" , OwnerName = "Alex", Model = 1998},
            //    new Car() { BrandName = "Honda" , OwnerName = "Phenix", Model = 2001},
            //    new Car() { BrandName = "Hundai" , OwnerName = "JRD Tata", Model = 1889},
            //    new Car() { BrandName = "Marithi" , OwnerName = "John", Model = 1999},
            //    new Car() { BrandName = "Audi" , OwnerName = "Castelman", Model = 2005}
            //};

            //IEnumerable<Car> enumerable = from car in listoCars
            //                              select car;
            //foreach (var car in enumerable)
            //{
            //    Console.WriteLine(car.OwnerName);
            //}

            string[] instructors = {"Aaron","Fritz","Scott","Keith"};

            IEnumerable<string> query = from instructor in instructors
                where instructor.Length == 5
                orderby instructor descending
                select instructor;            

            foreach (string qVariable in query)
            {
                Console.WriteLine(qVariable);
            }


            List<Employee> emp = new List<Employee>()
            {
                new Employee() {ID = 101,Name = "OneEmp",HireDate = new DateTime(2002,3,5)},
                new Employee() {ID = 102,Name = "TwoEmp",HireDate = new DateTime(2003,3,5)},
                new Employee() {ID = 103,Name = "ThreeEmp",HireDate = new DateTime(2000,7,5)},
                new Employee() {ID = 104,Name = "FourEmp",HireDate = new DateTime(2009,2,2)},
                new Employee() {ID = 105,Name = "FiveEmp",HireDate = new DateTime(2003,7,8)},
                new Employee() {ID = 106,Name = "SixEmp",HireDate = new DateTime(2010,1,15)}
            };

            IEnumerable<Employee> emplist = from e in emp
                where e.HireDate.Year >= 2005
                orderby e.ID descending
                select e;

            foreach (var VARIABLE in emplist)
            {
                Console.WriteLine("ID:" + VARIABLE.ID  + " Name: "+ VARIABLE.Name + " HireDate:" + VARIABLE.HireDate);
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
