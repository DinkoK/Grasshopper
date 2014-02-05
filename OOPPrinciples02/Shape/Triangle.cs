﻿
namespace Shape
{
    public class Triangle : Shape
    {

        public Triangle(double height, double width)
        {
            base.Height = height;
            base.Width = width;
        }

        public override double CalculateSurface()
        {
            return (base.Height * base.Width) / 2;
        }
    }
}
