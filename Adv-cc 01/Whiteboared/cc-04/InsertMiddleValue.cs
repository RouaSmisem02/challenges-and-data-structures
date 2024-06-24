using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_cc_01.cc_04
{
    public class InsertMiddleValue
    {
        static int[] MiddleValue(int[] arr, int value)
        {
            int middleIndex = (arr.Length + 1) / 2;
            int[] newArr = new int[arr.Length + 1];

            for (int i = 0; i < newArr.Length; i++)
            {
                if (i < middleIndex)
                {
                    newArr[i] = arr[i];
                }
                else if (i == middleIndex)
                {
                    newArr[i] = value;
                }
                else
                {
                    newArr[i] = arr[i - 1];
                }
            }

            return newArr;
        }
        public static void Main(string[] args)
        {
            int[] result1 = MiddleValue(new int[] { 1, 2, 3, 4 }, 5);
            Console.WriteLine(string.Join(", ", result1)); // Output: 1, 2, 5, 3, 4

            int[] result2 = MiddleValue(new int[] { 10, 20, 30, 40, 50 }, 25);
            Console.WriteLine(string.Join(", ", result2)); // Output: 10, 20, 30, 25, 40, 50

            int[] result3 = MiddleValue(new int[] { 7, 14, 21, 28 }, 10);
            Console.WriteLine(string.Join(", ", result3)); // Output: 7, 14, 10, 21, 28
        }

    }
}
