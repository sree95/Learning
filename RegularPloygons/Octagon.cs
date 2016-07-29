using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularPloygons
{
    public class Octagon : Object, IRegularPolygon
    {

        public int NumberOfSides { get; set; }

        public int SideLength { get; set; }


        public Octagon(int sideLength)
        {
            NumberOfSides = 8;
            SideLength = sideLength;
        }


        public double GetArea()
        {
            return 2 * (1 + Math.Sqrt(2)) * SideLength * SideLength;
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }
    }
}
