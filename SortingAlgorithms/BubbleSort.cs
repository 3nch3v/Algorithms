using System;

namespace SortingAlgorithms
{
    public static class BubbleSort
    {
        public static int[] OrderByAscending(int[] arr)
        {
            int[] result = new int[arr.Length];
            Array.Copy(arr, result, arr.Length);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (result[j] > result[j + 1])
                    {
                        var temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            }

            return result;
        }

        public static int[] OrderByDesending(int[] arr) 
        {
            int[] result = new int[arr.Length];
            Array.Copy(arr, result, arr.Length);

            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = 0; j < result.Length - 1; j++)
                {
                    if (result[j] < result[j + 1])
                    {
                        var temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            }

            return result;
        }
    }
}
