using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueries
{
    public class EmployeeRepository
    {

        public IEnumerable<Employee> GetAll()
        {
            return empList;
        }

        public void AddEmployee(Employee e)
        {
            empList.Add(e);
        }
        

        List<Employee> empList = new List<Employee>
        {
            new Employee() {DepartmentId = 1,Id = 1,Name = "SreeOne"},
            new Employee() {DepartmentId = 1,Id = 2,Name = "SreeTwo"},
            new Employee() {DepartmentId = 1,Id = 3,Name = "SreeThree"},
            new Employee() {DepartmentId = 1,Id = 4,Name = "SreeFour"},
            new Employee() {DepartmentId = 2,Id = 5,Name = "SreeFive"},
            new Employee() {DepartmentId = 2,Id = 6,Name = "SreeSix"}
        };
    }
}
