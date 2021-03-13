using System;

namespace MSSA.Optional.Parameters
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"What sound does a duck make?\n");
            string output = AnimalSound($"");
            Console.WriteLine($"{output}");
        } // Main method ends

        private static string AnimalSound(string input, string animal = "duck", string sound = "quack")
        {
            return ($"Well, the {animal} goes {sound}, of course.");
        } // AnimalSound method ends

    } // class ends
} // namespace ends

// Rewrite this code so that it has only one AnimalSound Method. 
// This Method will take two parameters: string animal and string sound. 
// These two parameters will each be "Optional" - they will have default values of "duck" and "quack" respectively.
