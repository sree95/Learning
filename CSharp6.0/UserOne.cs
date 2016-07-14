using CSharp6._0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;



namespace CSharp6._0
{
    public class UserOne
    {
        // Before C# 6.0

        private readonly Guid newGuid = Guid.NewGuid();

        private string _userName = string.Empty;


        public Guid Id
        {
            get
            {
                return newGuid;
            }
        }

        public string UserName
        {
            get
            {
                return _userName;
            }
            protected set
            {
                _userName = value;
            }
        }

        public static Guid _id { get; } = Guid.NewGuid(); 
      

        public string _userNameOne { get; protected set; } = string.Empty;


        // Auto Property Initializers
        public static Guid MyGuid { get; } = Guid.NewGuid();
        

        static void Main(string[] args)
        {
            // Using Static directive
            WriteLine("Hello! I'm Using Using Static directive feature of C# 6.0");            
            
            WriteLine(MyGuid);

            EmployeeO one = new EmployeeO();
            Console.WriteLine(one.EmployeeFullName);

            Dictionary<int, string> dict = new Dictionary<int, string>();

                       
        }

        
    }

    
}
    
