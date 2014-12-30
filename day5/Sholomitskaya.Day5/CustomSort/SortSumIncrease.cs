using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;
using ISortArray;

namespace CustomSort
{
    public class SortSumIncrease : ICustomComparer
    {
        #region public methods
        public int Compare(int[] a, int[] b)
        {
            if (a.Sum() == b.Sum())
                return 0;

            if (a.Sum() > b.Sum())
                return -1;
            else
                return 1;
        }
        #endregion
    }
}