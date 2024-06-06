namespace Adv_cc_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reversed Array
            int[] array = { 1, 2, 3, 4, 5 };
            int[] reversedArray = ReverseArray(array);

            Console.WriteLine("Original Array: [" + string.Join(", ", array) + "]");
            Console.WriteLine("Reversed Array: [" + string.Join(", ", reversedArray) + "]");
        }

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
