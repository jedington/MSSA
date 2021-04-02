using System;
using System.Runtime.InteropServices;

namespace Shapes
{
    class Hexagon : Shape
    {
        // fields
        protected double Side = 1.0;


        // constructors
        public Hexagon(double side, [Optional] string color)
            : base(color) // DRY
            => SetSide(side);
        // Hexagon const ends 


        // methods
        public override double GetArea()
            => 3 * Math.Sqrt(3) * Side * Side / 2;
        // GetArea method ends

        public override double GetPerimeter()
            => 6 * Side;
        // GetPerimeter method ends
        
        public double GetSide()
            => Side;
        //  GetSide method ends

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
            => $"Hexagon side value = {Side}, {base.ToString()}";
        // ToString method ends
    } // class ends
} // namespace ends