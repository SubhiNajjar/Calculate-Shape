using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Calculate.Shapes
{
    public abstract class Shape : IComparable<Shape>
    {
        private double _length;

        private double _width;


        protected Shape(double length, double width)
        {
            _length = length;
            _width = width;
        }

        protected double Length
        {
            get => _length;
            set
            {
                if (value >= 0) _length = value;
            }
        }

        protected double Width
        {
            get => _width;
            set
            {
                if(value >= 0 ) _width = value;
            }
        }

        public abstract double Area { get; }

        public abstract double Perimeter { get; }

        public int CompareTo(Shape other)
        {
            return Area.CompareTo(other.Area);
        }

        public override string ToString()
        {
            return "Längd : " + _length + "\nBredd : " + _width + "\nPerimeter : " + Perimeter + "\nArea:" + Area;
        }


    }
}
