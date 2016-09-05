using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************* Standard Catalog ***************************");
            StandardCatalog sc = new StandardCatalog();
            string str =  sc.Save();
            

            Console.WriteLine($"Concrete Class {str}");

            ISavable sble = new StandardCatalog();

            Console.WriteLine($"ISavable {sble.Save()}");

            IPersistable pble = new StandardCatalog();
            pble.Save();

            Console.WriteLine($"IPersistable {pble.Save()}");
            Console.WriteLine("********************* Standard Catalog ***************************\n\n");


            Console.WriteLine("********************* Explicit Catalog ***************************");
            ExplicitCatelog ec = new ExplicitCatelog();

            //Console.WriteLine($"Explicit catalog save method {ec.Save()}");

            ISavable save = new ExplicitCatelog();
            Console.WriteLine($"ISavable in Explicit catalog {save.Save()}");

            IPersistable persis = new ExplicitCatelog();
            Console.WriteLine($"IPersistable in Explicit catalog {persis.Save()}");

            Console.WriteLine("********************* Explicit Catalog ***************************\n\n");

            Console.WriteLine($"Casting  {((ISavable)ec).Save()}");

            Console.WriteLine($"Casting  {((IPersistable)ec).Save()}");

        }



        
    }
}
