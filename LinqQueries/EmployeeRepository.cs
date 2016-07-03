using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueries
{
    class EmployeeRepository
    {
        List<Employee> empList = new List<Employee>
        {
            new Employee() {DepartmentId = 101,Id = 1001,Name = "SreeOne"},
            new Employee() {DepartmentId = 102,Id = 1002,Name = "SreeTwo"},
            new Employee() {DepartmentId = 103,Id = 1003,Name = "SreeThree"},
            new Employee() {DepartmentId = 104,Id = 1004,Name = "SreeFour"},
            new Employee() {DepartmentId = 105,Id = 1005,Name = "SreeFive"}
        };
    }
}
