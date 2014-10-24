using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActionsWithArray;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 6, 8, 9, 4, 10 };
            Console.WriteLine("Our array:");
            Printer.printArray(array);
            Console.WriteLine("Sort by merge:");
            ArrayHelper.sortByMerge(ref array);
            Printer.printArray(array);
            Console.WriteLine("Sort by quik sort:");
            ArrayHelper.QuickSortByIncrease(ref array);
            Printer.printArray(array);
            int[][] matrix = 
                {
                    new int[] {1,3,5,7,9},
                    new int[] {0,2,4,6},
                    new int[] {11,22}
                };
            Console.WriteLine("Our matrix:");
            Printer.printMatrix(matrix);
            Console.WriteLine("Sorted matrix by increase sum:");
            MatrixHelper.SortBySumByIncreaseInMatrix(ref matrix);
            Printer.printMatrix(matrix);
            Console.WriteLine("Sorted matrix by increase smallest elements:");
            MatrixHelper.SortBySmallestElementByIncreaseInMatrix(ref matrix);
            Printer.printMatrix(matrix);
            Console.WriteLine("Sorted matrix  by decrease greatest elements:");
            MatrixHelper.SortByGreatestElementByDecreaseInMatrix(ref matrix);
            Printer.printMatrix(matrix);
            Console.ReadKey();
        }
    }
}

