using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number
{
    public static class PRepresentationOfNumber
    {
        #region public methods
        public static string TransferredToAnotherNumberSystem(int number, int baseOfNumberSystem)
        {
            checkNumber(number);
            checkNumberSystem(baseOfNumberSystem);
            string res = string.Empty;
            while (number != 0)
            {
                int rem = number % baseOfNumberSystem;
                number = number / baseOfNumberSystem;
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
        #endregion
        #region private methods
        private static void checkNumber(int number)
        {
            if ((number < 0) || ((number % 1.0 != 0)))
                throw new ArgumentOutOfRangeException("number must be int and positive");

        }
        private static void checkNumberSystem(int baseOfNumberSystem)
        {
            if (baseOfNumberSystem < 2 || baseOfNumberSystem > 16)
            {
                throw new ArgumentOutOfRangeException("incorrect base of number system");
            }
        }
        #endregion

    }
}
