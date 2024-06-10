using System;

public class cc2
{
    public int MaximumValue(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array must not be empty");
        }

        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }

    public static void Main(string[] args)
    {
        cc2 mvc = new cc2();

        int[] array1 = { 10, 15, 8, 6, 12 };
        int[] array2 = { 1, 3, 5, 7, 9 };
        int[] array3 = { 7, 9, 13, 25, 5 };
        int[] array4 = { -5, -10, -3, -4 };
        int[] array5 = { 42 };

        Console.WriteLine(mvc.MaximumValue(array1)); // Output: 15
        Console.WriteLine(mvc.MaximumValue(array2)); // Output: 9
        Console.WriteLine(mvc.MaximumValue(array3)); // Output: 25
        Console.WriteLine(mvc.MaximumValue(array4)); // Output: -3
        Console.WriteLine(mvc.MaximumValue(array5)); // Output: 42
    }
}
