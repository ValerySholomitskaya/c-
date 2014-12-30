using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static int Sum(this int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum = sum + array[i];
            return sum;
        }
        public static int Max(this int[] array)
        {
            int max = array[0];
            for (int j = 0; j < array.Length; j++)
            {
                if (max < array[j])
                {
                    max = array[j];
                }
            }
            return max;
        }
    }
}
