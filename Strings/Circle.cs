using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    sealed class Circle
    {
        private double radius;

        public double Calculate(Func<double, double> fn)
        {
            return fn(radius);
        }
    }
}
