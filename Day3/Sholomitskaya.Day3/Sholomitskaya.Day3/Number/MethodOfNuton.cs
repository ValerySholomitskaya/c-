using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number
{
    public static class MethodOfNuton
    {
        #region private methods
        private static void checkRoot(int root)
        {
            if (root <= 0)
            {
                throw new ArgumentOutOfRangeException("root must be positive and great then zero");
            }
        }
        private static void checkEps(double eps)
        {
            if (eps <= 0 || eps > 1)
            {
                throw new ArgumentOutOfRangeException("eps must be positive and less 1");
            }
        }
        #endregion
        #region public methods
        public static double methodOfNuton(double number, int root, double eps)
        {
            checkEps(eps);
            checkRoot(root);
            if (root % 2 == 0 && number < 0)
                throw new ArgumentException("impossible to do this");
            if (number == 0)
                return 0;
            double xk = number / root;
            double xk1 = xk;
            do
            {
                xk = xk1;
                xk1 = (1.0 / root) * ((root - 1) * xk + number / Math.Pow(xk, root - 1));
            }
            while (Math.Abs(xk - xk1) > eps);
            return xk1;
        }
        #endregion
    }
}
