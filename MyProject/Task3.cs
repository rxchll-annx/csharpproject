using System;

namespace MyProject
{
    class Task3
    {
        static void Main(string[] args)
        {
            // Array initialization
            int[] numbers = { 3, 7, 12, 19, 21, 25, 30 };

            // Ask the user for input
            Console.Write("Enter a number to search for: ");
            int target = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            // For loop to search the array
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    Console.WriteLine($"Number found at position {i}!");
                    found = true;
                    break; // stop searching
                }
            }

            // If the number was not found
            if (!found)
            {
                Console.WriteLine("Number not found in the list.");
            }
        }
    }
}
