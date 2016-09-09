using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    class Program : INamedSavable
    {
        static void Main(string[] args)
        {

        }

        public string Save()
        {
            throw new NotImplementedException();
        }

        public string Save(string str)
        {
            throw new NotImplementedException();
        }
    }
}
