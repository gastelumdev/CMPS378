using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_2.Classes
{
    internal class Circle : IShape
    {
        // Declare only one dimension since we just need the radius
        double dimension1;
        // Constructor only thakes the one input
        public Circle(double d1)
        {
            dimension1 = d1;
        }
        // Override the interface method to return the area of the circle
        public double getArea()
        {
            return (Math.PI * Math.Pow(dimension1, 2));
        }
        // Override the interface method to return the perimeter of the circle
        public double getPerimeter()
        {
            return 2 * Math.PI * dimension1;
        }
    }
}
