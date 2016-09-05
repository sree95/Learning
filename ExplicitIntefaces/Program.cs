using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitIntefaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Catelog log = new Catelog();
            Console.WriteLine(log.Save());

            ISavable saveble = new Catelog();
            Console.WriteLine(saveble.Save());

            Console.WriteLine(((ISavable)log).Save()); 
        }
    }
}
