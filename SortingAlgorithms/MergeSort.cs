using System;

namespace SortingAlgorithms
{
    public static class MergeSort
    {
        private const string byAscending = "ascending";
        private const string byDesending = "desending";

        public static int[] OrderByAscending(int[] arr)
        {
            int[] result = CopyInput(arr);
            MergeSortRecursive(result, 0, result.Length - 1, byAscending);
            return result;
        }

        public static int[] OrderByDesending(int[] arr)
        {
            int[] result = CopyInput(arr);
            MergeSortRecursive(result, 0, result.Length - 1, byDesending);
            return result;
        }

        private static void MergeSortRecursive(int[] numbers, int left, int rigth, string sortingType)
        {
            if (left < rigth)
            {
                int middle = left + (rigth - left) / 2;

                MergeSortRecursive(numbers, left, middle, sortingType);
                MergeSortRecursive(numbers, middle + 1, rigth, sortingType);
                Merge(numbers, left, middle, rigth, sortingType);
            }     
        }

        private static void Merge(int[] numbers, int left, int middle, int rigth, string sortingType)
        {
            int i, j, k;
            int leftElementsCount = middle - left + 1;
            int rigthElementsCount = rigth - middle;

            int[] leftElements = new int[leftElementsCount];
            int[] rigthElements = new int[rigthElementsCount];

            for (i = 0; i < leftElementsCount; i++)
            {
                leftElements[i] = numbers[left + i];
            }

            for (j = 0; j < rigthElementsCount; j++)
            {
                rigthElements[j] = numbers[middle + 1 + j];
            }

             i = 0;
             j = 0;
             k = left;

            while (i < leftElementsCount && j < rigthElementsCount)
            {
                if (leftElements[i] <= rigthElements[j]
                    && sortingType == byAscending)
                {
                    numbers[k] = leftElements[i];
                    i++;
                }
                else if (leftElements[i] >= rigthElements[j]
                    && sortingType == byDesending)
                {
                    numbers[k] = leftElements[i];
                    i++;
                }
                else
                {
                    numbers[k] = rigthElements[j];
                    j++;
                }

                k++;
            }

            while (i < leftElementsCount)
            {
                numbers[k] = leftElements[i];
                i++;
                k++;
            }

            while (j < rigthElementsCount)
            {
                numbers[k] = rigthElements[j];
                j++;
                k++;
            }
        }

        private static int[] CopyInput(int[] arr)
        {
            int[] copy = new int[arr.Length];
            Array.Copy(arr, copy, arr.Length);
            return copy;
        }

    }
}
