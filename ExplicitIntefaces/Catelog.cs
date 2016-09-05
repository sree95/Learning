using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitIntefaces
{
    public class Catelog : ISavable
    {
        public string Save() => "Catalog class save method";

        string ISavable.Save() => "Interface driven save method";
    }
}
