using System;

namespace CommonElements
{
    public class CommonFinder
    {
        public static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 0 };
            int[] array2 = { 2, 3, 4, 9 };

            int[] commonElements = FindCommonElements(array1, array2);

            Console.WriteLine("Common Elements: " + string.Join(", ", commonElements));
        }

        public static int[] FindCommonElements(int[] array1, int[] array2)
        {
            int[] common = new int[Math.Min(array1.Length, array2.Length)];
            int index = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        bool alreadyExists = false;
                        for (int k = 0; k < index; k++)
                        {
                            if (common[k] == array1[i])
                            {
                                alreadyExists = true;
                                break;
                            }
                        }
                        if (!alreadyExists)
                        {
                            common[index++] = array1[i];
                        }
                    }
                }
            }

            Array.Resize(ref common, index);
            return common;
        }
    }
}
