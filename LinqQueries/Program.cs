using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleEmployeeQueries();
        }

        private static void SimpleEmployeeQueries()
        {
            throw new NotImplementedException();
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
