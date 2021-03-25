using System;

namespace Ch5ExFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c;

            for (int i = 0; i < 20; i++) // 20 lines as specified
            {
                if (i <= 1)
                {
                    c = i;
                }
                else
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                Console.Write($"{c}\n");
            }
                
            // // Notes nesting loops
            // for (int i = 1; i <= 10; i++)
            // {
            //     for (int j = 1; j <= 10; j++)
            //     {
            //         Console.Write($"i = {i}; j = {j}\n");
            //     }
            // }

        } // main method ends
    } // class ends
} // namespace ends
