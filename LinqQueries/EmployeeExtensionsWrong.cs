using LinqQueries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExtensionsWrong
{
    public static class EmployeeExtensions
    {
        public static IEnumerable<Employee> Where(this IEnumerable<Employee> sequence,Func<Employee,bool> predicate)
        {
            List<Employee> empList = new List<Employee>();

            foreach (Employee e in sequence)
            {
                if (predicate(e))
                {
                    empList.Add(e);
                }
            }

            return empList;
        }       
    }
}
