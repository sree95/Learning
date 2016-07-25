using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6._0
{
    class EmployeeO
    {
        string fullName = null;

        public EmployeeO()
        {
            EmployeeId = Guid.NewGuid();
            EmployeeFirstName = "Sreenivas";
            EmployeeLastName = "Parimi";
            EmployeeFullName = string.Format($"{EmployeeFirstName} {EmployeeLastName}");            
        }


        public Guid EmployeeId { get; set; }

        public string EmployeeFirstName { get; set; }

        public string EmployeeLastName { get; set; }
        
        public string EmployeeFullName { get; set; }       

    }

}
