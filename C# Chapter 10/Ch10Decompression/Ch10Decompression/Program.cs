using System;
using System.Collections.Generic;

namespace Ch10Decompression
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] exampleOne = {4, 5, 4, 10, 2, 5};
            int[] exampleTwo = {1, 1, 1, 2, 1, 3, 1, 4, 1, 5};
            int[] exampleThree = {1, 1, 2, 2, 3, 3, 4, 4, 5, 5};
            int[] exampleFour = {5, 1, 4, 2, 3, 3, 2, 4, 1, 5};

            Console.WriteLine($"Array Ex1: [{string.Join(", ", Decompress(exampleOne))}]\n");
            Console.WriteLine($"Array Ex2: [{string.Join(", ", Decompress(exampleTwo))}]\n");
            Console.WriteLine($"Array Ex3: [{string.Join(", ", Decompress(exampleThree))}]\n");
            Console.WriteLine($"Array Ex4: [{string.Join(", ", Decompress(exampleFour))}]\n");
        } // Main method ends
        static int[] Decompress(int[] received)
        {
            List<int> decode = new List<int>();
            int i = 0, j = 0;
            while ( i < received.Length)
            {
                while (j++ < received[i])
                {
                    decode.Add(received[i + 1]);
                }
                i += 2;
            }
            return decode.ToArray();
        } // Decompress method ends
    } // class ends
} // namespace ends