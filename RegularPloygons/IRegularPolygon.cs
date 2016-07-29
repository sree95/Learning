using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularPloygons
{
    interface IRegularPolygon
    {
        int NumberOfSides { get; set; }

        int SideLength { get; set; }

        double GetPerimeter();

        double GetArea();
    }
}
