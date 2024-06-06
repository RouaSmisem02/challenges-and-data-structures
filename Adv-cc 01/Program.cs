using System;
using System.Collections.Generic;

namespace Adv_cc_01
{
    public class MostFrequentNumberFinder
    {
        public static int FindMostFrequentNumber(int[] numbers)
        {
            Dictionary<int, int> numberCount = new Dictionary<int, int>();
            int mostFrequentNumber = numbers[0];
            int maxCount = 0;

            foreach (int num in numbers)
            {
                if (numberCount.ContainsKey(num))
                {
                    numberCount[num]++;
                }
                else
                {
                    numberCount[num] = 1;
                }

                if (numberCount[num] > maxCount)
                {
                    maxCount = numberCount[num];
                    mostFrequentNumber = num;
                }
            }

            return mostFrequentNumber;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Reversed Array
            int[] array = { 1, 2, 3, 4, 5 };
            int[] reversedArray = ReverseArray(array);

            Console.WriteLine("Original Array: [" + string.Join(", ", array) + "]");
            Console.WriteLine("Reversed Array: [" + string.Join(", ", reversedArray) + "]");

            //--------------------------------------------------------------------
            // Most Frequent Number
            int[] inputNumbers = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };

            Console.WriteLine("Input Array: [" + string.Join(", ", inputNumbers) + "]");

            int result = MostFrequentNumberFinder.FindMostFrequentNumber(inputNumbers);
            Console.WriteLine("Most frequent number: " + result);

            // Reverse Array
            static int[] ReverseArray(int[] inputArray)
            {
                int size = inputArray.Length;
                int[] reversedArray = new int[size];

                for (int i = 0; i < size; i++)
                {
                    reversedArray[i] = inputArray[size - 1 - i];
                }

                return reversedArray;
            }
        }
    }
}
