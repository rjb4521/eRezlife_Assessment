using System;
using System.Collections.Generic;
using System.Text;

namespace eRezlife_Assessment
{
    class Triangle
    {
         public void AreaOfTriangle()
         {
            int side1 = 4, side2 = 4, side3 = 4;
            double perimeter = (side1 + side2 + side3) / 2;
            double Area = Math.Sqrt(perimeter * (perimeter - side1) * (perimeter - side2) * (perimeter - side3));
            Console.WriteLine("Area of a Triangle = " + Area);

         }
    }
}
