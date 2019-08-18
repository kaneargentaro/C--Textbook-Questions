using System;

namespace Shapes_Class
{
    class Triangle : Shape
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            _SideA = sideA;
            _SideB = sideB;
            _SideC = sideC;
        }

        private double _SideA;
        public double SideA
        {
            get { return _SideA; }
            set { _SideA = value; }
        }

        private double _SideB;
        public double SideB
        {
            get { return _SideB; }
            set { _SideB = value; }
        }

        private double _SideC;
        public double SideC
        {
            get { return _SideC; }
            set { _SideC = value; }
        }

        public override double GetArea()
        {
            double s = 0.5 * (_SideA + _SideB + _SideC);
            return Math.Sqrt(s * (s - _SideA) * (s - _SideB) * (s - _SideC));
        }

        public override double GetPerimeter()
        {
            return (SideA + SideB + SideC);
        }
    }
}