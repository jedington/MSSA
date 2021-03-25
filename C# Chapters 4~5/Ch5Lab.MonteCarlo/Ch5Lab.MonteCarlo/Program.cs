using System;

namespace MSSA.Monte.Carlo.PI
{
    class Program
    {
        public static void Main(string[] args)
        {
            double x, y, z;
            int countInside = 0, countOutside = 0;

            Console.Write("Input number of random coordinates: "); // preference
            int theInput = Convert.ToInt32(Console.ReadLine());
            // int theInput = int.Parse(args[0]); // 0-10/1-100/2-1000/3-10000

            for (int i = 0; i < theInput; i++)
            {
                Random randomNum = new Random();
                (x, y) = RandomXY(randomNum);
                z = Hypotenuse(x, y);
                // Console.WriteLine(z);
                if (z <= 1.0)
                {
                    countInside++;
                }
                else
                {
                    countOutside++;
                }
            }

            double estPi = ((double) countInside / (double) theInput) * 4;
            double diffOfPi = Math.Abs(Math.PI - estPi); // Math.Abs to force positive
            
            Console.WriteLine($"Coordinates inside the Circle: {countInside}");
            Console.WriteLine($"Coordinates outside the Circle: {countOutside}");
            Console.WriteLine($"PI estimated from inside coord: {estPi}");
            Console.WriteLine($"Difference of real PI and estimated PI: {diffOfPi}");
        } // Main method ends

        private static (double rnX, double rnY) RandomXY(Random rnJesus)
        {
            // write code to gen a random x and a random y using rnJesus
            double rnX = rnJesus.NextDouble();
            // Console.WriteLine(rnX);
            double rnY = rnJesus.NextDouble();
            // Console.WriteLine(rnY);

            // return both random x and random y
            return (rnX, rnY);
        } // RandomXY method ends

        private static double Hypotenuse(double x, double y)
            // Pythagorean Theorem: a^2 + b^2 = c^2
            => Math.Sqrt(x * x + y * y); 
        // Hypotenuse method ends
    } // class ends
} // namespace ends

// 1. The program only accounts for one quadrant or 1/4 of a circle.
// Multiplying by x4 is simply estimating a full circle's value of PI.

// 2. The estimation toward PI gets more accurate when increasing parameter value.

// 3. No, because of the parameter that is used and was sourced from System.Random.

// 4. 10,000,000 ~ or more.

// 5. Depends, as it becomes more accurate exponentially when using higher value parameters. 

// 6. Monte Carlo is a popular probability method for sampling and experimentation.
// Can range from a simple probability  for dice rolls or a PI estimation to...
// as far as modern algorithms for statistics and machine learning simulations.