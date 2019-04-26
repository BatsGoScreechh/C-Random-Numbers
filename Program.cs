using System;
using System.Collections.Generic;
using System.Collections;

namespace random_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> numbers = new List<int> {
            random.Next(6),
            random.Next(6),
            random.Next(6),
            random.Next(6),
            random.Next(6),
            random.Next(6),
};

            // Console.WriteLine(numbers[i]);


            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == i)
                {
                    Console.WriteLine($"numbers list contains {i}");
                }
                else
                {
                    Console.WriteLine($"numbers list does not contains {i}");
                }
            }
            // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.

        }
    }
}
