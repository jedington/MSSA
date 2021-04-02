using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            // int i = (int) 3.0; // cast
            // Rectangle r0 = new Rectangle(); // default constructor / no arg
            // A PIE // Object-Oriented Programming
            // Abstraction, Polymorphism, Inheritance, Encapsulation

            ////////////////////////////////////////////// Shape
            

            ////////////////////////////////////////////// Rectangle
            Rectangle r1 = new Rectangle(-1,-2);
            r1.SetLength(-10);
            r1.SetWidth(-15);

            Console.WriteLine($"Perimeter of Rectangle r1 ={r1.GetPerimeter()}");
            Console.WriteLine($"Area of Rectangle r1 = {r1.GetArea()}");


            ////////////////////////////////////////////// Square
            Square s1 = new Square(-1, "red");
            s1.SetSide(-13);

            Console.WriteLine($"Perimeter of Square s1 is {s1.GetPerimeter()}");
            Console.WriteLine($"Area of Square s1 is {s1.GetArea()}");


            ////////////////////////////////////////////// Triangle
            Triangle t1 = new Triangle(-1,-1,-1, "green");

            Console.WriteLine($"Perimeter of Triangle t1 is {t1.GetPerimeter()}");
            Console.WriteLine($"Area of Triangle t1 is {t1.GetArea()}");


            ////////////////////////////////////////////// Circle
            Circle c1 = new Circle(-1, "yellow");
            c1.SetRadius(-13);

            Console.WriteLine($"Circumference of Circle c1 is {c1.GetPerimeter()}");
            Console.WriteLine($"Area of Circle c1 is {c1.GetArea()}");

            Shape s = new Square(2);
            Console.WriteLine($"Area of Square 's' is: {s.GetArea()}");
            Console.WriteLine($"Perimeter of Square 's' is: {s.GetPerimeter()}");
        } // main method ends
    } // class ends
} // namespace ends
