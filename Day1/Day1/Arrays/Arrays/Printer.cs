using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    static class Printer
    {
        public static void printArray(Int32[]array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine(" ");
        }
        public static void printMatrix(Int32 [][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    System.Console.Write(matrix[i][j] + " ");
                }
                System.Console.WriteLine();
            }

        }
    }
}
