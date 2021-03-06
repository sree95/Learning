﻿using LinqQueries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExtensionsGood
{
    public static class EmployeeExtensions
    {
        public static IEnumerable<Employee> Where(this IEnumerable<Employee> sequence,Func<Employee,bool> predicate)
        {
            foreach (Employee e in sequence)
            {
                if (predicate(e))
                {
                    yield return e;
                }
            }
        }
    }
}
