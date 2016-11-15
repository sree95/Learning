using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectHandler
{
    public class MyType
    {
        public MyType()
        {
            Console.WriteLine("Created an instance of MyType in an App Domain with the");
            Console.WriteLine($"hashCode{AppDomain.CurrentDomain.GetHashCode()}");
            Console.WriteLine("");
        }


        public int GetAppDomainHashCode() => AppDomain.CurrentDomain.GetHashCode();


    }
}
