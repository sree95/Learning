using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodopeartions
{
    class Program
    {
        static void Main()
        {
            //BaseClass bCls = new BaseClass();
            //bCls.Print();

            //DerivedClass dCls = new DerivedClass();
            //dCls.Print();

            //BaseClass bDCls = new DerivedClass();
            //bDCls.Print();

            //((DerivedClass)bDCls).Print();


            //A a = new A();

            //a.Foo();


            //B b = new B();
            //b.Foo();

            //C c = new C();
            //c.Foo();

            //A a = new B();
            //a.Foo();

            //DerivedClass dcc = new DerivedClass();
            //dcc.Print();

            #region MethodHiding

            TC t1 = new TC();
            t1.Demo();

            #endregion

            #region MethodOverriding

            BClass bcls = new BClass();
            bcls.Make();

            DClass dcls = new DClass();
            dcls.Make();


            BClass bdcls = new DClass();
            bdcls.Make();

            #endregion

        }
    }

    class BC
    {
        public void Demo()
        {
            Console.WriteLine("BC: Demo");
        }
    }

    class DC: BC
    {
        new public void Demo()
        {
            Console.WriteLine("DC Demo");
        }
    }

    class TC: DC
    {
        new public void Demo()
        {
            Console.WriteLine("TC Demo");
        }
    }


    class BClass 
    {
        public virtual void Make()
        {
            Console.WriteLine("B Made");
        }
    }

    class DClass :BClass
    {

        public override void Make()
        {
            Console.WriteLine("D Made");
        }
    }



}
