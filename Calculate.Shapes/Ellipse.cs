using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate.Shapes
{
    public class Ellipse : Shape
    {
        public Ellipse(double length, double width) : base (length, width)
        {

        }
        public override double Area
        {
            get { return Math.PI * (Width / 2.0) * (Length / 2.0); }
        }

        public override double Perimeter
        {
            get
            {
                return 2 * Math.PI *
                       Math.Sqrt(((Width / 2.0) * (Width / 2.0) + (Length / 2.0) * (Length / 2.0)) / 2.0);
            }
        }

    }
}
