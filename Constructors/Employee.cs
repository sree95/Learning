using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Employee
    {
        private string employeeName;

        private string EmpoloyeeID;

        static Employee()
        {
            Console.WriteLine("Static Constructor Invoked");
        }

        public Employee(string name)
        {
            this.employeeName = name;
        }
                 

    }
}
