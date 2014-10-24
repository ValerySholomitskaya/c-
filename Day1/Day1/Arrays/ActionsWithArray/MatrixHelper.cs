using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionsWithArray
{
    public static class MatrixHelper
    {
        #region private static mathods
        private static void checkMatrix(Int32[][] matrix)
        {
            if (matrix == null || matrix.Length == 0)
            {
                throw new ArgumentOutOfRangeException("matrix is null or has no elements");
            }
            if (matrix != null || matrix.Length != 0)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    if (matrix[i] == null || matrix[i].Length == 0)
                        throw new ArgumentOutOfRangeException("one of rows in matrix is null or has no elements");
                }
            }
         }
        private static void SwapRowsInMatrix(Int32[][] matrix, Int32 firstIndex, Int32 secondIndex)
        {
            Int32[] temp;
            temp = matrix[firstIndex];
            matrix[firstIndex] = matrix[secondIndex];
            matrix[secondIndex] = temp;

        }
        private static Int32 SumOfRowOfMatrix(Int32[] array)
        {
            Int32 sum = 0;
            for (Int32 j = 0; j < array.Length; j++)
            {
                sum = sum + array[j];
            }
            return sum;
        }
        private static Int32 SmallestElementInRowOfMatrix(Int32[] array)
        {
            Int32 smallestElement = array[0];
            for (Int32 j = 0; j < array.Length; j++)
            {
                if (smallestElement > array[j])
                {
                    smallestElement = array[j];
                }
            }
            return smallestElement;
        }
        private static Int32 GreatestElementInRowOfMatrix(Int32[] array)
        {
            Int32 greatestElement = array[0];
            for (Int32 j = 0; j < array.Length; j++)
            {
                if (greatestElement < array[j])
                {
                    greatestElement = array[j];
                }
            }
            return greatestElement;
        }
        private static Int32[][] SortBySumByIncrease(Int32[][] matrix)
        {
            for (Int32 i = 0; i < matrix.Length - 1; i++)
            {
                for (Int32 j = 0; j < matrix.Length - i - 1; j++)
                {
                    if (SumOfRowOfMatrix(matrix[j]) > SumOfRowOfMatrix(matrix[j + 1]))
                        SwapRowsInMatrix(matrix, j, j + 1);
                }
            }
            return matrix;
        }
        private static Int32[][] SortBySumByDecrease(Int32[][] matrix)
        {
            for (Int32 i = 0; i < matrix.Length - 1; i++)
            {
                for (Int32 j = 0; j < matrix.Length - i - 1; j++)
                {
                    if (SumOfRowOfMatrix(matrix[j]) < SumOfRowOfMatrix(matrix[j + 1]))
                        SwapRowsInMatrix(matrix, j, j + 1);
                }
            }
            return matrix;
        }
        private static Int32[][] SortBySmallestElementByIncrease(Int32[][] matrix)
        {
            for (Int32 i = 0; i < matrix.Length - 1; i++)
            {
                for (Int32 j = 0; j < matrix.Length - i - 1; j++)
                {
                    if (SmallestElementInRowOfMatrix(matrix[j]) > SmallestElementInRowOfMatrix(matrix[j + 1]))
                        SwapRowsInMatrix(matrix, j, j + 1);
                }
            }
            return matrix;
        }
        private static Int32[][] SortBySmallestElementByDecrease(Int32[][] matrix)
        {
            for (Int32 i = 0; i < matrix.Length - 1; i++)
            {
                for (Int32 j = 0; j < matrix.Length - i - 1; j++)
                {
                    if (SmallestElementInRowOfMatrix(matrix[j]) < SmallestElementInRowOfMatrix(matrix[j + 1]))
                        SwapRowsInMatrix(matrix, j, j + 1);
                }
            }
            return matrix;
        }
        private static Int32[][] SortByGreatestElementByIncrease(Int32[][] matrix)
        {
            for (Int32 i = 0; i < matrix.Length - 1; i++)
            {
                for (Int32 j = 0; j < matrix.Length - i - 1; j++)
                {
                    if (GreatestElementInRowOfMatrix(matrix[j]) > GreatestElementInRowOfMatrix(matrix[j + 1]))
                        SwapRowsInMatrix(matrix, j, j + 1);
                }
            }
            return matrix;
        }
        private static Int32[][] SortByGreatestElementByDecrease(Int32[][] matrix)
        {
            for (Int32 i = 0; i < matrix.Length - 1; i++)
            {
                for (Int32 j = 0; j < matrix.Length - i - 1; j++)
                {
                    if (GreatestElementInRowOfMatrix(matrix[j]) < GreatestElementInRowOfMatrix(matrix[j + 1]))
                        SwapRowsInMatrix(matrix, j, j + 1);
                }
            }
            return matrix;
        }
        #endregion
        #region public static methods
        public static void SortBySumByIncreaseInMatrix(ref Int32[][] matrix)
        {
            checkMatrix(matrix);
            matrix = SortBySumByIncrease(matrix);
            /*
            Int32[][] sortedMatrix = SortBySumByIncrease(matrix);
            for (Int32 i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = sortedMatrix[i][j];
                }
            }
             * */
        }
        public static void SortBySumByDecreaseInMatrix(ref Int32[][] matrix)
        {
            checkMatrix(matrix);
            matrix = SortBySumByDecrease(matrix); ;
            /*
            Int32[][] sortedMatrix = SortBySumByDecrease(matrix);
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = sortedMatrix[i][j];
                }
            }
             * */
        }
        public static void SortBySmallestElementByIncreaseInMatrix(ref Int32[][] matrix)
        {
            checkMatrix(matrix);
            matrix = SortBySmallestElementByIncrease(matrix);
            /*
            Int32[][] sortedMatrix = SortBySmallestElementByIncrease(matrix);
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = sortedMatrix[i][j];
                }
            }
             * */
        }
        public static void SortBySmallestElementByDecreaseInMatrix(ref Int32[][] matrix)
        {
            checkMatrix(matrix);
            matrix = SortBySmallestElementByDecrease(matrix);
            /*
            Int32[][] sortedMatrix = SortBySmallestElementByDecrease(matrix);
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = sortedMatrix[i][j];
                }
            }
             * */
        }
        public static void SortByGreatestElementByIncreaseInMatrix(ref Int32[][] matrix)
        {
            checkMatrix(matrix);
            matrix = SortByGreatestElementByIncrease(matrix);
            /*
            Int32[][] sortedMatrix = SortByGreatestElementByIncrease(matrix);
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = sortedMatrix[i][j];
                }
            }
             * */
        }
        public static void SortByGreatestElementByDecreaseInMatrix(ref Int32[][] matrix)
        {
            checkMatrix(matrix);
            matrix = SortByGreatestElementByDecrease(matrix);
            /*
            Int32[][] sortedMatrix = SortByGreatestElementByDecrease(matrix);
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = sortedMatrix[i][j];
                }
            }
             * */
        }
        #endregion
       
    }
}
