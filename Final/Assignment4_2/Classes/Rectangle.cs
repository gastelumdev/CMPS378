using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_2.Classes
{
    internal class Rectangle : IShape
    {
        // Declare two dimensions for the Rectangle
        double dimension1;
        double dimension2;
        // Constructor only takes the two dimensions of the rectangle
        public Rectangle(double d1, double d2)
        {
            dimension1 = d1;
            dimension2 = d2;
        }
        // Override the interface method to return the area of the square
        public double getArea()
        {
            return (dimension1 * dimension2);
        }
        // Override the interface method to return the perimeter of the square
        public double getPerimeter()
        {
            return (2 * (dimension1 + dimension2));
        }
    }
}
