using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueries
{
    class DepartmentRepository
    {

        public IEnumerable<Department> GetAll()
        {
            return _departments;
        }

        List<Department> _departments = new List<Department>()
        {
            new Department {ID = 1,Name = "Engineering" },
            new Department {ID = 2,Name = "Sales" },
            new Department {ID = 3,Name = "Skunkworks" }
        };
    }
}
