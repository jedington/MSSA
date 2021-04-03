using System;

namespace WealthiestPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] exampleOne = 
            {
                new []{ 100, 200, 300 },
                new []{ 500 },
                new []{ 400, 600, 500, 0 }
            };
            int[][] exampleTwo = 
            {
                new []{ 100, 500 },
                new []{ 700, 300 },
                new []{ 300, 500 }
            };
            Console.WriteLine($"Wealthiest Person from Example One is worth: " +
            $"{string.Join("", CalcWealthiest(exampleOne))}\n");
            Console.WriteLine($"Wealthiest Person from Example Two is worth: " +
            $"{string.Join("", CalcWealthiest(exampleTwo))}\n");
        } // Main method ends

        static int CalcWealthiest(int[][] accounts)
        {
            int i = 0, wealthiest = 0;
            while (i < accounts.Length)
            { 
                int j = 0, factor = 0;
                while (j < accounts[i].Length)
                {
                    factor += accounts[i][j++];
                }
                if (factor > wealthiest)
                {
                    wealthiest = factor;
                }
                i++;
            }
            return wealthiest;
        } // CalcWealthiest
    } // class ends
} // namespace ends