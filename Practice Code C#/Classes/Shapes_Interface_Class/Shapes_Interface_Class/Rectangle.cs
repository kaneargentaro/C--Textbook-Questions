﻿using System;

namespace Shapes_Interface_Class
{
    class Rectangle : IShape
    {
        public Rectangle(double length, double height)
        {
            _Length = length;
            _Height = height;
        }

        private double _Height;
        public double Height
        {
            get { return _Height; }
            set { _Height = value; }
        }

        private double _Length;
        public double Length
        {
            get { return _Length; }
            set { _Length = value; }
        }

        public double GetArea()
        {
            return _Height * _Length;
        }

        public double GetPerimeter()
        {
            return ((2 * _Height) + (2 * _Length));
        }
    }
}
