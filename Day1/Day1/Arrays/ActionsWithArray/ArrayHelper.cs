using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionsWithArray
{
    public static class ArrayHelper
    {
        #region private static methods
        private static void checkArray(Int32[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentOutOfRangeException("array is null or has no elements");

        }
        private static Int32[] Merge(Int32[] arrayInFirstPart, Int32[] arrayInSecondPart)
        {
            Int32 a = 0, b = 0;
            Int32[] mergedArray = new Int32[arrayInFirstPart.Length + arrayInSecondPart.Length];
            for (Int32 i = 0; i < arrayInFirstPart.Length + arrayInSecondPart.Length; i++)
            {
                if (b < arrayInSecondPart.Length && a < arrayInFirstPart.Length)
                    if (arrayInFirstPart[a] > arrayInSecondPart[b])
                    {
                        mergedArray[i] = arrayInSecondPart[b++];
                    }
                    else
                    {
                        mergedArray[i] = arrayInFirstPart[a++];
                    }
                else
                    if (b < arrayInSecondPart.Length)
                    {
                        mergedArray[i] = arrayInSecondPart[b++];
                    }
                    else
                    {
                        mergedArray[i] = arrayInFirstPart[a++];
                    }
            }
            return mergedArray;
        }
        private static Int32[] MergeSort(Int32[] array)
        {
            if (array.Length == 1) return array;
            Int32 middleIndex = array.Length / 2;
            return Merge(MergeSort(array.Take(middleIndex).ToArray()), MergeSort(array.Skip(middleIndex).ToArray()));
        }
        private static Int32[] QuickSortByIncrease(Int32[] array, Int32 leftIndex, Int32 rightIndex)
        {
            Int32 temp;
            Int32 x = array[(leftIndex + rightIndex) / 2];
            Int32 i = leftIndex;
            Int32 j = rightIndex;
            while (i <= j)
            {
                while (array[i] < x) i++;
                while (array[j] > x) j--;
                if (i <= j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < rightIndex)
            {
                QuickSortByIncrease(array, i, rightIndex);
            }

            if (leftIndex < j)
            {
                QuickSortByIncrease(array, leftIndex, j);
            }
            return array;
        }
        private static Int32[] QuickSortByDecrease(Int32[] array, Int32 leftIndex, Int32 rightIndex)
        {
            Int32 temp;
            Int32 x = array[(leftIndex + rightIndex) / 2];
            Int32 i = leftIndex;
            Int32 j = rightIndex;
            while (i <= j)
            {
                while (array[i] > x) i++;
                while (array[j] < x) j--;
                if (i <= j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < rightIndex)
            {
                QuickSortByIncrease(array, i, rightIndex);
            }

            if (leftIndex < j)
            {
                QuickSortByIncrease(array, leftIndex, j);
            }
            return array;
        }
        #endregion
        #region public static methods
        public static void sortByMerge(ref Int32[] array)
        {
            checkArray(array);
            array = MergeSort(array);
            /*
                 Int32[] sortedArray = MergeSort(array);
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = sortedArray[i];
                }
             * */
        }
        public static void QuickSortByIncrease(ref Int32[] array)
        {
            checkArray(array);
            array=QuickSortByIncrease(array, 0, array.Length - 1);
/*
            Int32[] sortedArray = QuickSortByIncrease(array, 0, array.Length - 1);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = sortedArray[i];
            }
         */
        }
        public static void QuickSortByDecrease(Int32[] array)
        {
            checkArray(array);
            array = QuickSortByDecrease(array, 0, array.Length - 1);
            /*
            Int32[] sortedArray = QuickSortByDecrease(array, 0, array.Length - 1);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = sortedArray[i];
            }
             * */

        }
        #endregion

    }
}