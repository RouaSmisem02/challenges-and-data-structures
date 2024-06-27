namespace Find_Duplicates_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 16, 8, 31, 17, 15, 23, 17, 8 };
            int[] duplicates = GetDuplicates(numbers);

            Console.WriteLine("Duplicate values: " + string.Join(", ", duplicates));
        }

        static int[] GetDuplicates(int[] numbers)
        {
            Dictionary<int, int> numberCounts = new Dictionary<int, int>();
            List<int> duplicates = new List<int>();

            foreach (int number in numbers)
            {
                if (numberCounts.ContainsKey(number))
                {
                    numberCounts[number]++;
                    if (numberCounts[number] == 2)
                    {
                        duplicates.Add(number);
                    }
                }
                else
                {
                    numberCounts[number] = 1;
                }
            }

            return duplicates.ToArray();
        }
    }
    }
