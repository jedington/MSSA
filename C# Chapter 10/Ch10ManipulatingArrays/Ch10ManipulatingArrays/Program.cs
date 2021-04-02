using System;

namespace Ch10ManipulatingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {0, 2, 4, 6, 8, 10};
            int[] b = {1, 3, 5, 7, 9};
            int[] c = {3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9};

            Console.WriteLine($"Sum of values within array is: {Sum(c)}\n"); // 1.Sum
            Console.WriteLine($"Average value within array is: {Average(c)}\n"); // 2.Average
            Reverse(b); // 3.Reverse
            Console.WriteLine($"Maximum value within array is: {Maximum(c)}\n"); // 4.Maximum
            Rotate(a, 3); // 5.Rotate
            Sort(c); // 6.Sort
        } // Main method ends

        public static int Sum(int[] numbers)
        {
            int numSum = numbers[0];
            foreach (int num in numbers)
            {
                numSum += num;
            }
            return numSum;
        } // Sum method ends

        public static double Average(int[] numbers) 
            => (double)Sum(numbers) / numbers.Length;
        // Average method ends

        public static void Reverse(int[] numbers)
        {
            Array.Reverse(numbers);
            // foreach(int num in numbers)
            // {
            //     Console.Write($"{num} ");
            // }
            // Console.Write("= Array Reversed \n");
            Console.WriteLine($"Array Reversed: [{string.Join(", ", numbers)}]\n");
        } // Reverse method ends

        public static int Maximum(int[] numbers)
            // => numbers.Max();
        {
            int numMax = numbers[0];
            foreach (int findMax in numbers)
            {
                if (findMax > numMax)
                {
                    numMax = findMax;
                }
            }
            return numMax; 
        } // Maximum method ends

        public static void Rotate(int[] numbers, int rotateLeft)
        {
            for (int i = 0; i < rotateLeft; i++)
            {
                int temp = numbers[0];
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }

                numbers[numbers.Length - 1] = temp;
            }
            // foreach(int num in numbers)
            // {
            //     Console.Write($"{num} ");
            // }
            // Console.Write("= Array Rotated \n");
            Console.WriteLine($"Array Rotated: [{string.Join(", ", numbers)}]\n");
        } // Rotate method ends

        public static void Sort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)  
            {  
                for (int j = i + 1; j < numbers.Length; j++)  
                {  
                    if (numbers[i] > numbers[j])  
                    {  
                        int temp = numbers[i];  
                        numbers[i] = numbers[j];  
                        numbers[j] = temp;  
                    }  
                }  
            }
            // foreach(int num in numbers)
            // {
            //     Console.Write($"{num} ");
            // }
            // Console.Write("= Array Sorted \n");
            Console.WriteLine($"Array Sorted: [{string.Join(", ", numbers)}]\n");
        } // Sort method ends
    } // class ends
} // namespace ends