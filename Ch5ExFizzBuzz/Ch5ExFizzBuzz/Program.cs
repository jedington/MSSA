using System;

namespace Ch5ExFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int count = 1; count < 101; count++)
            {
                if ((count % 3 == 0) && (count % 5 == 0))
                    Console.Write($"\n{count} - FizzBuzz");
                else if (count % 3 == 0)
                    Console.Write($"\n{count} - Fizz");
                else if (count % 5 == 0)
                    Console.Write($"\n{count} - Buzz");
                else
                    Console.Write($"\n{count}");
            }
        } // main method ends
    } // class ends
} // namespace ends
