using System;
using System.Collections.Generic;

namespace FindDuplicatesChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 16, 8, 31, 17, 15, 23, 17, 8 };
            int[] duplicates = FindDuplicates(input);

            Console.WriteLine("Duplicate values: " + string.Join(", ", duplicates));
        }

        static int[] FindDuplicates(int[] array)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();
            List<int> duplicates = new List<int>();

            foreach (int number in array)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                    if (counts[number] == 2)
                    {
                        duplicates.Add(number);
                    }
                }
                else
                {
                    counts[number] = 1;
                }
            }

            return duplicates.ToArray();
        }
    }
}
