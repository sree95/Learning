using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularPloygons
{
    public abstract class AbstractRegularPolygon
    {
        public int NumberOfSides { get; set; }

        public int SideLength { get; set; }

        public AbstractRegularPolygon(int numofSide, int sideLength)
        {
            NumberOfSides = numofSide;
            SideLength = sideLength;
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        public abstract double GetArea(); 
    }
}
