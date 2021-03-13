using System;

namespace MSSA.Mathematical.Formulas
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Part 1 & 2 ... combined radius usage
            Console.WriteLine($"Part 1 & 2, circumference, area, volume of a circle.\n");
            
            Console.Write($"Enter an integer for the radius: ");
            string strradius = Console.ReadLine();
            int intradius = Convert.ToInt32(strradius);
            
            double circumference = 2 * Math.PI * intradius;
            Console.WriteLine($"The circumference is {circumference}");

            double areaCircle = Math.PI * (intradius * intradius);
            Console.WriteLine($"The area is {areaCircle}");
            
            double volume = ((4 / 3) * Math.PI * (intradius * intradius * intradius)) / 2;
            Console.WriteLine($"The volume is {volume}");


            // Part 3
            Console.WriteLine($"\nPart 3, area of a triangle (Heron's formula).\n");

            Console.Write($"Input the first value (length of side A): ");
            double aSide = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Input the first value (length of side B): ");
            double bSide = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Input the first value (length of side C): ");
            double cSide = Convert.ToDouble(Console.ReadLine());

            double p = (aSide + bSide + cSide) / 2;
            double areaTriangle = Math.Sqrt(p * (p - aSide) * (p - bSide) * (p - cSide));
            Console.WriteLine($"The area is {areaTriangle}");


            // Part 4
            Console.WriteLine($"\nPart 4, solving a quadratic equation.\n");

            Console.Write($"Input the first value (as a): ");
            double aQuad = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Input the second value (as b): ");
            double bQuad = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Input the third value (as c): ");
            double cQuad = Convert.ToDouble(Console.ReadLine());

            double posAnswer = (-bQuad + Math.Sqrt(bQuad * bQuad) - (4 * aQuad * cQuad) / (2 * aQuad));
            Console.WriteLine($"The positive solution is {posAnswer}");

            double negAnswer = (-bQuad - Math.Sqrt(bQuad * bQuad) - (4 * aQuad * cQuad) / (2 * aQuad));            
            Console.WriteLine($"The negative solution is {negAnswer}");
        }
    }
}
