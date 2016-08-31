using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleNM
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<string, int,int> t = new Tuple<string, int,int>("One", 1,2);
            Console.WriteLine(t.Item1);
            Console.WriteLine(t.Item2);

            var tuple = Tuple.Create<string, int, string>("Numbert", 2, "Numebr");

            //Tuple<int, int, int, int, int, int, int, int> tip = new Tuple<int, int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7, 8);

            //Console.WriteLine(tip.Item7);

            var tupe = Tuple.Create<int, int, int, int, int, int,int,int> (1, 2, 3, 4, 5, 6, 7, 8);

            Console.WriteLine(tupe.Rest);
            
                //var tup8 = Tuple.Create<int, int, Tuple<int, int>, int, int, int, int, Tuple<int, int>>(2, 3, new Tuple<int, int>(19, 20), 7, 11, 13, 16, new Tuple<int,int>(19,20));

            //Console.WriteLine(tup8.Rest.Item1.Item1);
            //Console.WriteLine(tup8.Item3.Item1);



        }


        
    }
}
