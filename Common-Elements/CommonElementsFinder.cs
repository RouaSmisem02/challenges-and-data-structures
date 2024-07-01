using System;

namespace Challenges.CommonElements
{
    public class CommonElementsFinder
    {
        public static int[] CommonElements(int[] array1, int[] array2)
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
