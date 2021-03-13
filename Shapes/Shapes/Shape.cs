using System;

namespace Shapes
{
    class Shape
    {
        // fields
        protected string Color;


        // constructors
        protected Shape(string color)
        {
            SetColor(color); // DRY
        } // Shape const ends


        // methods
        public string GetColor()
            => Color;
        // GetColor method ends

        public bool SetColor(string color)
        {
            if (color != null && color != "" && color.Length > 0)
            {
                Color = color;
                return true;
            }
            else
            {
                return false;
            }
        } 
        // Set Color method ends

        public override string ToString()
            => $"is a Shape & color = {Color}";
        // ToString method ends
    } // class ends
} // namespace ends