using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate.Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double length, double width) : base(length, width)
        {

        }
        public override double Area
        {
            get { return Length * Width; }
        }

        public override double Perimeter
        {
            get { return 2 * (Length + Width); }
        }

    }
}
