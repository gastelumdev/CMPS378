using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_2.Classes
{
    internal class Triangle : IShape
    {
        // Declare two dimensions for the base and height
        double dimension1;
        double dimension2;
        double dimension3;
        // Constructor takes in the base and height
        public Triangle(double d1, double d2, double d3)
        {
            dimension1 = d1;
            dimension2 = d2;
            dimension3 = d3;
        }
        // Override the interface method to return the area of the triangle
        public double getArea()
        {
            double s = (dimension1 + dimension2 + dimension3) / 2;
            return Math.Sqrt(s * (s - dimension1) * (s - dimension2) * (s - dimension3));
        }
        // Override the interface method to return the perimeter of the triangle
        public double getPerimeter()
        {
            return (dimension1 + dimension2 + dimension3);
        }
    }
}
