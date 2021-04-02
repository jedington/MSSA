using System;
using System.Runtime.InteropServices;

namespace Shapes
{
    class Triangle : Shape
    {
        // fields
        protected double SideA = 1.0;
        protected double SideB = 1.0;
        protected double SideC = 1.0;


        // constructors
        public Triangle(double a, double b, double c, [Optional] string color)
            : base(color) // DRY
            => SetSides(SideA, SideB, SideC);
        // Triangle const ends

        // methods
        public override double GetArea()
            //disabled//  => Math.Sqrt (GetPerimeter() / 2 * (GetPerimeter() / 2 - sideA) * (GetPerimeter() / 2 - sideB) * (GetPerimeter() / 2 - sideC));
        {
            double hPer = GetPerimeter() / 2;
            return Math.Sqrt(hPer * (hPer - SideA) * (hPer - SideB) * (hPer - SideC));
        } // GetArea method ends

        public override double GetPerimeter()
            => SideA + SideB + SideC;
        // GetPerimeter method ends

        public (double sideA, double sideB, double sideC) GetSides()
            => (SideA, SideB, SideC);
        // GetSides method ends

        public void SetSides(double a, double b, double c)
        {
            if ((a + b) > c && (a + c) > b && (b + c) > a)
            {
                SideA = a;
                SideB = b;
                SideC = c;
            }
        } // SetSides method ends

        public override string ToString() 
            =>  $"Triangle side values... Side A = {SideA}, Side B = {SideB}, Side C = {SideC}, {base.ToString()}"; 
        // ToString method ends
    } // class ends
} // namespace ends
