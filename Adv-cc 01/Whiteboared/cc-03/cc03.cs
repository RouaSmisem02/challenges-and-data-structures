//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Adv_cc_01.Whiteboared.cc_03
//{
//    internal class cc03
//    {
//        public static int[] RemoveMiddleValue(int[] arr)
//        {
//            int length = arr.Length;
//            if (length == 0) return arr;

//            int middleIndex = length / 2;
//            int[] result = (length % 2 == 0) ? new int[length - 2] : new int[length - 1];
//            int resultIndex = 0;

//            for (int i = 0; i < length; i++)
//            {
//                if ((length % 2 == 0 && (i == middleIndex - 1 || i == middleIndex)) ||
//                    (length % 2 != 0 && i == middleIndex))
//                {
//                    continue;
//                }
//                result[resultIndex++] = arr[i];
//            }

//            return result;
//        }

//        public static void Main()
//        {
//            int[] testArray = { 1, 2, 3, 4, 5 };
//            int[] result = RemoveMiddleValue(testArray);
//            Console.WriteLine("Original array: " + string.Join(", ", testArray));
//            Console.WriteLine("Modified array: " + string.Join(", ", result));
//        }
//    }
//}
