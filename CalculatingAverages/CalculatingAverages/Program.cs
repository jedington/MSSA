using System;

namespace MSSA.Calc.Avg
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 10 numbers...definitely gotta be a better way to do this.
            Console.WriteLine($"Enter a value between 0-100\n");

            Console.Write($"Enter the first grade: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Enter the second grade: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Enter the third grade: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Enter the fourth grade: ");
            double num4 = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Enter the fifth grade: ");
            double num5 = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Enter the sixth grade: ");
            double num6 = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Enter the seventh grade: ");
            double num7 = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Enter the eighth grade: ");
            double num8 = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Enter the ninth grade: ");
            double num9 = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Enter the tenth grade: ");
            double num10 = Convert.ToDouble(Console.ReadLine());

            // Not error handling, but better than nothing, I guess.
            if (num1 > 100 || num2 > 100 || num3 > 100 || num4 > 100 || num5 > 100
                || num6 > 100 || num7 > 100 || num8 > 100 || num9 > 100 || num10 > 100
                || num1 < 0 || num2 < 0 || num3 < 0 || num4 < 0 || num5 < 0
                || num6 < 0 || num7 < 0 || num8 < 0 || num9 < 0 || num10 < 0)
                Console.WriteLine($"\nWarning! One of the grades is outside the range of 0-100.");

            // Sum
            double sumGrade = (num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10);

            // Average
            double averageGrade = (num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10) / 10;

            // Call LetterCalc Method + Sum and Average results 
            char letterGrade = LetterCalc(averageGrade);
            Console.WriteLine($"\nThe Sum of the grades is: {sumGrade}");
            Console.WriteLine($"\nThe Average grade is: {averageGrade}\nOr a letter grade of: {letterGrade}");
        } // Main method ends

        private static char LetterCalc(double calcGrade)
        {
            char letterGrade = 'F';
            if (calcGrade >= 90 && calcGrade <= 100)
            {
                letterGrade = 'A';
            }
            else if (calcGrade >= 80 && calcGrade < 90)
            {
                letterGrade = 'B';
            }
            else if (calcGrade >= 70 && calcGrade < 80)
            {
                letterGrade = 'C';
            }
            else if (calcGrade >= 60 && calcGrade < 70)
            {
                letterGrade = 'D';
            }
            return letterGrade;
        } // LetterCalc method ends
    } // Program class ends
} // namespace ends
