using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularPloygons
{
    public class ConcreteRegularPloygon
    {
        public int NumberOfSides { get; set; }

        public int SideLength { get; set; }

        public ConcreteRegularPloygon(int numofSides, int sideLegth)
        {
            NumberOfSides = numofSides;
            SideLength = sideLegth;
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }


    }
}
