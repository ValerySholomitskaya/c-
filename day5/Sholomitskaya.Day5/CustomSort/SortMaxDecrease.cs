using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISortArray;
using ExtensionMethods;

namespace CustomSort
{
    public class SortMaxDecrease : ICustomComparer
    {
        public int Compare(int[] a, int[] b)
        {
            if (a.Max() == b.Max())
                return 0;

            if (a.Max() < b.Max())
                return -1;
            else
                return 1;
        }


    }
}
