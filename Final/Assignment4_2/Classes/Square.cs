using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_2.Classes
{
    internal class Square : IShape
    {
        // Declare only one dimension since all the sides of a square are the same
        double dimension1;
        // Constructo only thakes the one input
        public Square(double d1)
        {
            dimension1 = d1;
        }
        // Override the interface method to return the area of the square
        public double getArea()
        {
            return dimension1 * dimension1;
        }
        // Override the interface method to return the perimeter of the square
        public double getPerimeter()
        {
            return 4 * dimension1;
        }
    }
}
