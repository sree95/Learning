using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodopeartions
{
    class DerivedClass : BaseClass
    {

        new public void Print()
        {
            Console.WriteLine("Derived Class Print");
        }
    }


    class A
    {

        public virtual void Foo()
        {
            Console.WriteLine("A::Foo()");
        }
    }

    class B :A
    {
        public override void Foo()
        {
            Console.WriteLine("B::Foo()");
        }        
    }

    class C : A
    {

    }
}
