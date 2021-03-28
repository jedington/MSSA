using System;
using System.Runtime.InteropServices;

namespace Shapes
{
    class Circle : Shape
    {
        // fields
        protected double Radius = 1.0;


        // constructors
        public Circle(double radius, [Optional] string color)
            : base(color) // DRY
            => SetRadius(radius);
        // Circle const ends


        // methods
        public override double GetArea()
            => Math.PI * (Radius * Radius);
        // GetArea method ends

        public override double GetPerimeter()
            => GetCircumference();
        // GetPerimeter method ends

        public double GetCircumference()
            => 2 * Math.PI * Radius; 
        // Get Circumference method ends

        public double GetRadius()
            => Radius; 
        // GetRadius method ends

        public void SetRadius(double radius)
        {
            if (radius < 0)
            {
                radius = Math.Abs(radius);
            }
            else if (radius == 0)
            {
                radius = 1.0;
            }
            Radius = radius;
        } // SetRadius method ends

        public override string ToString()
            => $"Circle radius value = {Radius}, {base.ToString()}";
        // ToString method ends
    } // class ends
} // namespace ends
