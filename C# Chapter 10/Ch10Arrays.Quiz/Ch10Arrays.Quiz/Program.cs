using System;

namespace Ch10Arrays.Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////// Ten Numbers
            int[] tenNumbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. Enter a Number: ");
                tenNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");
            foreach (int number in tenNumbers)
            {
                Console.Write($"{number}, ");
            }

            /////////////////////////////////////////// Chosen Numbers
            Console.Write("\n\nHow many numbers would you like to enter? ");
            int numberCount = Convert.ToInt32(Console.ReadLine());
            int[] chosenNumbers = new int[numberCount];

            for (int i = 0; i < numberCount; i++)
            {
                Console.Write($"{i + 1}. Enter a Number: ");
                chosenNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int number in chosenNumbers)
            {
                Console.Write($"{number}, ");
            }
        } // main method ends
    } // class ends
} // namespace ends
