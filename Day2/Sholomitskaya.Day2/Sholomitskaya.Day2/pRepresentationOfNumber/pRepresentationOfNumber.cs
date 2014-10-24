using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number
{
    public class pRepresentationOfNumber
    {
        private int sourceNumber;
        public int SourceNumber
        {
            get { return sourceNumber; }
            set
            {
                if ((value > 0) && (!(value % 1.0 != 0)))
                {
                    sourceNumber = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("number must be int and positive");
                }
            }
        }
        public string TransferredToAnotherNumberSystem(int baseOfNumberSystem)
        {
            if (baseOfNumberSystem < 2 || baseOfNumberSystem > 16)
            {
                throw new ArgumentOutOfRangeException("incorrect base of number system");
            }
            string res = "";
            int copySourceNumber = sourceNumber;
            while (copySourceNumber != 0)
            {
                int rem = copySourceNumber % baseOfNumberSystem;
                copySourceNumber = copySourceNumber / baseOfNumberSystem;
                if (rem > 9)
                {
                    rem = rem + ((int)'A' - 10);
                    res = (char)rem + res;
                }
                else
                    res = rem.ToString() + res;
            }
            return res;
        }
    }
}
