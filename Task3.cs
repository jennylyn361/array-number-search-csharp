using System;

class NumberSearchApp
{
    static void Main(string[] args)
    {
        // Initialize the required array
        int[] numbers = { 3, 7, 12, 19, 21, 25, 30 };
        
        // Prompt user for input
        Console.Write("Enter a number to search for: ");
        int target = int.Parse(Console.ReadLine());
        
        bool found = false;
        
        // For loop to iterate through array elements
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target)
            {
                Console.WriteLine($"Number found at position {i}!");
                found = true;
                break; // Stop loop immediately when found
            }
        }
        
        // Message if number not found
        if (!found)
        {
            Console.WriteLine("Number not found in the list.");
        }
    }
}
