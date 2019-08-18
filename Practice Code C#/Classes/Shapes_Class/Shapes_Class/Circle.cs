using System;

namespace Shapes_Class
{
    class Circle : Shape
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

        public override double GetArea()
        {
            return Math.PI * _Radius * _Radius;
        }

        public override double GetPerimeter()
        {
            return (2 * Math.PI * _Radius);
        }
    }
}
