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
            var query1 = from e in new EmployeeRepository().GetAll()
                         where e.DepartmentId < 3 && e.Id < 10
                         orderby e.DepartmentId descending
                         orderby e.Name ascending
                         select e;

            var query2 = new EmployeeRepository().GetAll().Where(d => d.DepartmentId < 3 && d.Id < 10).OrderByDescending(d => d.DepartmentId).OrderBy(n => n.Name);

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
