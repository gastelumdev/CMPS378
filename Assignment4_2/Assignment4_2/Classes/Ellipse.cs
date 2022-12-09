using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_2.Classes
{
    internal class Ellipse : IShape
    {
        // Declare two dimensions for the ellipse
        double dimension1;
        double dimension2;
        // Constructor only takes the two dimensions
        public Ellipse(double d1, double d2)
        {
            dimension1 = d1;
            dimension2 = d2;
        }
        // Override the interface method to return the area of the ellipse
        public double getArea()
        {
            return (Math.PI * dimension1 * dimension2);
        }
        // Override the interface method to return the perimeter of the ellipse
        public double getPerimeter()
        {
            double h = (Math.Pow((dimension1 - dimension2), 2)) / (Math.Pow((dimension2 + dimension1), 2));
            return (Math.PI * (dimension1 + dimension2) * (1 + ((3 * h)/(10 + Math.Sqrt(4 - (3 * h)))) ) );
        }
    }
}
