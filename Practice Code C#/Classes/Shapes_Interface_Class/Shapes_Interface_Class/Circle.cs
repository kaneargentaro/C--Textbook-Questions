using System;

namespace Shapes_Interface_Class
{
    class Circle : IShape
    {
        public Circle(double radius)
        {
            _Radius = radius;
        }

        private double _Radius;
        public double Radius
        {
            get { return _Radius; }
            set { _Radius = value; }
        }

        public double GetArea()
        {
            return Math.PI * _Radius * _Radius;
        }

        public double GetPerimeter()
        {
            return (2 * Math.PI * _Radius);
        }
    }
}
