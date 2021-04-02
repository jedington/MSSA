using System;
using System.Runtime.InteropServices;

namespace Shapes
{
    class Rectangle : Shape
    {
        // fields
        protected double Length = 1.0;
        protected double Width = 1.0;


        // constructors
        public Rectangle(double length, double width, [Optional] string color)
            : base(color) // DRY
        {
            SetLength(length);
            SetWidth(width);
        } // Rectangle const ends

        
        // methods
        public override double GetArea()
            => Length * Width;
        // GetArea method ends

        public override double GetPerimeter()
            => 2 * (Length + Width);
        // GetPerimeter method ends

        public double GetLength()
            => Length;
        // GetLength method ends

        public double GetWidth()
            => Width;
        // GetWidth method ends

        public void SetLength(double length)
        {
            if (length < 0)
            {
                length = Math.Abs(length);
            }
            else if (length == 0)
            {
                length = 1.0;
            }
            Length = length;
        } // SetLength method ends

        public void SetWidth(double width)
        {
            if (width < 0)
            {
                width = Math.Abs(width);
            }            
            else if (width == 0)
            {
                width = 1.0;
            }
            Width = width;
        } // SetWidth method ends

        public (double length, double width) GetDimensions()
            => (Length, Width);
        // GetDimensions method ends

        public void SetDimensions(double length, double width)
        {
            SetLength(length);
            SetWidth(width);
        } // SetDimensions method ends

        public override string ToString()
            => $"Rectangle side values... Length = {Length} & Width = {Width}, {base.ToString()}";
        // ToString method ends
    } // class ends
} // namespace ends