using System;

namespace MSSA.CIP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //0. place the value of 17 into 'input' as a string
            string input = "17";
            //1. convert string to int & place into variable 'count'
            var count = Convert.ToInt32(input);
            //2. Use pre-increment operator on 'count'
            ++count;
            //3. Print count using string interpolation
            Console.Write($"Count is {count}\n");
        }
    }
}