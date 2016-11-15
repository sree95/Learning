using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace ObjectHandler
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"The hashcode for teh default AppDomain is {AppDomain.CurrentDomain.GetHashCode()}");

            Console.WriteLine("");

            // Creating anothet AppDomain

            AppDomain domain =  AppDomain.CreateDomain("AnotherDomain", null, (AppDomainSetup)null);

            ObjectHandle handle = domain.CreateInstance("ObjectHandleAssembly", "MyType");

            object obj =  handle.Unwrap();

            MyType mType = (MyType)obj;

            if (RemotingServices.IsTransparentProxy(mType))
            {
                Console.WriteLine("The unwrapped object is a proxy.");
            }
            else
            {
                Console.WriteLine("The unwrapped object is not a proxy!");
            }

            Console.WriteLine("");
            Console.Write("Calling a method on the object located in an AppDomain with the hash code ");
            Console.WriteLine(mType.GetAppDomainHashCode());


        }
    }
}
