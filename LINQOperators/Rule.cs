using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQOperators
{
    public class Rule<T>
    {
        public Func<T, bool> Test { get; set; }

        public string Message { get; set; }
    }
}



