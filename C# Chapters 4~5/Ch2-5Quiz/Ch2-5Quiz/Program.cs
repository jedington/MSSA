using System;

namespace Ch2_5Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // // 1. (5 points) Write some code in Main that prints out the numbers from 1 to 1000.
            // for (int i = 1; i <= 1000; i++)
            // {
            //     Console.WriteLine(i);
            // }
            // 
            // // 2. (5 points) Write some more code in Main that prints out the numbers in reverse from 1000 down to 1.
            // for (int i = 1000; i >= 1; i--)
            // {
            //     Console.WriteLine(i);
            // }
            // 
            // // 3. (10 points) Write some more code in Main that prints out only the even numbers from 1 to 1000.
            // for (int i = 1; i <= 1000; i++)
            // {
            //     if( i%2 == 0 )
            //     {
            //         Console.WriteLine(i);
            //     }
            // }
            // 
            // // 4. (10 points) Write some more code in Main that prints out the numbers 1, 2, 4, 8, 16, 32, 64, and so on (doubling each time), starting at 1 and ending at 1 million (1,000,000).
            // for (int i = 1; i < 1_000_000; i*=2)
            // {
            //     Console.WriteLine(i);
            // }

            // test methods
            ProblemSix(10, 20);
            ProblemSix(20, 10); 
            ProblemSeven(10, 20);
            ProblemEight(5, 10, 15);


        } // main method ends

        // 5. (15 points) Write a Method that takes an integer parameter and prints out the numbers from 1 up to the value of the parameter that it received.
        static void ProblemFive(int number = 10)
        {
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }

        // 6. (15 points) Write another Method that takes two integer parameters (begin and end), doesn't print anything out, but adds up all the numbers from begin through end and returns that sum as an integer.
        static int ProblemSix(int begin, int end)
        {
            int sumNumbers = 0;
            if (begin > end)
            {
                for (int i = end; end <= begin; i++)
                {
                    sumNumbers = sumNumbers + i;
                }
            }
            else if (end < begin)
            {
                for (int i = begin; begin <= end; i++)
                {
                    sumNumbers = sumNumbers + i;
                }
            }
            return sumNumbers;
        }

        // 7a. (20 points) Write another Method that takes two integer parameters (length and width), doesn't print anything out, but returns two integer values: the perimeter (length 2 + width 2), and the area (length * width).
        static (int perim, int area) ProblemSeven(int length, int width)
            => (2 * (length + width), length * width);


        // 8a. (20 points) Write another Method that takes three integer parameters (a, b, and c), and returns the value of the largest (a, or b, or c).
        static int ProblemEight(int a, int b, int c)
            => a < b ? (a < c ? c : a) : (b < c ? c : c);
        
        // Mind the Gap!
    } // class ends
} // namespace ends
