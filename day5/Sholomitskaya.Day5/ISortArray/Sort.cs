using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISortArray
{
    public static class Sort
    {
        #region public method
        public static void SortMatrix(int[][] array, ICustomComparer comparator)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparator.Compare(array[i], array[j]) == 1)
                        Swap(ref array[i], ref array[j]);
                }
            }
        }
        #endregion
        #region private method
        private static void Swap(ref int[] a, ref int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }
        #endregion
    }
}
