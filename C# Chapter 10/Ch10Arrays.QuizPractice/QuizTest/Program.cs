using System;

namespace QuizTest
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.WriteLine("What is your favorite Letter?");
            
            string favLetter = Console.ReadLine();
            char favChar = Convert.ToChar(favLetter);

            int numberOfLetter = Array.IndexOf(alphabet, favChar);
            alphabet[numberOfLetter] = Convert.ToChar(favLetter.ToUpper());

            foreach (char letter in alphabet)
            {
                Console.Write($"{letter}, ");
            }

            Console.WriteLine("\n\nHow many favorite numbers do you have?\n");

            int favNumberCount = Convert.ToInt32(Console.ReadLine());
            int[] favNumbers = new int[favNumberCount];

            for (int i = 0; i < favNumberCount; i++)
            {
                Console.Write("Favorite Number: ");
                favNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int number in favNumbers)
            {
                Console.Write($"{number}, ");
            }
        }
    }
}