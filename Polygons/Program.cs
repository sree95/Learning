using RegularPloygons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    class Program
    {
        static void Main(string[] args)
        {
            // Square
            Square sq = new Square(5);

            DisplayPolygon("Square", sq);

            // Triangle

            Triangle tri = new Triangle(5);
            DisplayPolygon("Triangle", tri);

            //Octogon

            Octagon oct = new Octagon(5);
            DisplayPolygon("Octagon", oct);
        }





        public static void DisplayPolygon(string polygon, dynamic sq)
        {
            try
            {
                Console.WriteLine(polygon + " Num of Sides: " + sq.NumberOfSides);
                Console.WriteLine(polygon + " Side Length: " + sq.SideLength);
                Console.WriteLine(polygon + " Perimeter: " + sq.GetPerimeter());
                Console.WriteLine(polygon + " Area: " + sq.GetArea());
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            

        }
    }
}
