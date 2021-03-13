using System;

namespace MSSA.Reducing.Steps
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Input random digit(s) (whole numbers only): ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int numOfSteps = NumberOfSteps(userInput);
            Console.WriteLine($"Number of steps = {numOfSteps}");
        } // Main method ends

        static int NumberOfSteps(int num)
        {
            int stepUpOne = 0;
            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                }
                else
                {
                    num = num - 1;
                }
                stepUpOne++;
            }
            return stepUpOne;
        } // NumberOfSteps method ends
    } // class ends
} // namespace ends
