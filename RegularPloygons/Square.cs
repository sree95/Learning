using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularPloygons
{
    public class Square : ConcreteRegularPloygon
    {


        public Square(int sideLegth) 
            : base(4, sideLegth) { }


        public override double GetArea()
        {
            return SideLength * SideLength;
        }


    }
}
