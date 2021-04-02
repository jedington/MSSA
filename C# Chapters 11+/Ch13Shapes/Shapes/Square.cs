using System;
using System.Runtime.InteropServices;

namespace Shapes
{
    class Square : Shape
    {
        // fields
        protected double Side = 1.0;


        // constructors
        public Square(double side, [Optional] string color)
            : base(color) // DRY
            => SetSide(side);
        // Square const ends 


        // methods
        public override double GetArea()
            => Side * Side;
        // GetArea method ends

        public override double GetPerimeter()
            => 4 * Side;
        // GetPerimeter method ends
        
        public double GetSide()
            => Side;
        // GetSide method ends

        public void SetSide(double side)
        {
            if (side < 0)
            {
                side = Math.Abs(side);
            }
            else if (side == 0)
            {
                side = 1.0;
            }
            Side = side;
        } //  SetSide method ends

        public override string ToString()
            => $"Square side value = {Side}, {base.ToString()}";
        // ToString method ends
    } // class ends
} // namespace ends
