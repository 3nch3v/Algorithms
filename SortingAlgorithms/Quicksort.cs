using System;

namespace SortingAlgorithms
{
    public static class Quicksort
    {
        private const string byAscending = "ascending";
        private const string byDesending = "desending";

        public static int[] OrderByAscending(int[] input)
        {
            int[] result = CopyInput(input);
            Sort(result, 0, input.Length - 1, byAscending);
            return result;
        }

        public static int[] OrderByDescending(int[] input)
        {
            int[] result = CopyInput(input);
            Sort(result, 0, input.Length - 1, byDesending);
            return result;
        }

        private static void Sort(int[] arr, int left, int right, string orderType)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right, orderType);

                Sort(arr, left, pivot - 1, orderType);
                Sort(arr, pivot + 1, right, orderType);
            }
        }

        private static int Partition(int[] arr, int left, int right, string orderType)
        {
            int pivot = arr[right];
            int index = left;    

            for (int j = left; j < right; j++)
            {
                if (orderType == byAscending)
                {
                    if (arr[j] <= pivot)
                    {
                        SwapNumbers(arr, index, j);
                        index++;
                    }
                }
                else if(orderType == byDesending)
                {
                    if (arr[j] >= pivot)
                    {
                        SwapNumbers(arr, index, j);
                        index++;
                    }
                }
            }

            SwapNumbers(arr, index, right);
            return index;
        }

        private static void SwapNumbers(int[] arr, int index, int j)
        {
            int temp = arr[index];
            arr[index] = arr[j];
            arr[j] = temp;
        }

        private static int[] CopyInput(int[] arr)
        {
            int[] copy = new int[arr.Length];
            Array.Copy(arr, copy, arr.Length);
            return copy;
        }
    }
}
