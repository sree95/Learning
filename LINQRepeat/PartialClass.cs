using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQRepeat
{
    partial class PartialClass
    {

        partial void OnCreated();

        //partial void OnCreated()
        //{
        //    Console.WriteLine("Partial Method");
        //}

        public void Created()
        {
            OnCreated();
            Console.WriteLine("Non Partial method");
        }
    }
}
