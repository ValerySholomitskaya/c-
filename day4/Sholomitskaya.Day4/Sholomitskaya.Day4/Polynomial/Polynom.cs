using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial
{
    public class Polynom
    {

        #region private members
        private int _degree;// степень полинома
        private double[] _coefficients;// коэффициенты полинома 
        #endregion
        #region constructor
        public Polynom(int deg, double[] c)
        {
            Degree = deg;
            Сoefficients = c;
        } 
        #endregion
        #region public methods
        public int Degree// получить значение степени
        {
            get { return _degree; }
            set { checkDegree(value); _degree = value; }
        }
        public double[] Сoefficients //получить коэффициенты полинома
        {
            get { return _coefficients; }
            set { ckeckСoefficients(value); _coefficients = value; }
        }
        public double Calculate(double x)
        {
            int n = Сoefficients.Length - 1;
            double result = Сoefficients[n];
            for (int i = n - 1; i >= 0; i--)
            {
                result = x * result + _coefficients[i];
            }
            return result;
        } 
        #endregion
        #region overloaded operators
        public static Polynom operator +(Polynom a, Polynom b)
        {
            int degree;
            double[] coefficients;
            if (a.Degree > b.Degree)
            {
                coefficients = new double[a.Сoefficients.Length];
                degree = a.Degree;
                for (int i = 0; i < b.Сoefficients.Length; ++i)
                {
                    coefficients[i] = a.Сoefficients[i] + b.Сoefficients[i];
                }
                for (int i = b.Сoefficients.Length; i < a.Сoefficients.Length; ++i)
                {
                    coefficients[i] = a.Сoefficients[i];
                }
            }
            else
            {
                coefficients = new double[b.Сoefficients.Length];
                degree = b.Degree;
                for (int i = 0; i < a.Сoefficients.Length; ++i)
                {
                    coefficients[i] = a.Сoefficients[i] + b.Сoefficients[i];
                }
                for (int i = a.Сoefficients.Length; i < b.Сoefficients.Length; ++i)
                {
                    coefficients[i] = b.Сoefficients[i];
                }
            }
            Polynom c = new Polynom(degree, coefficients);
            return c;
        }
        public static Polynom operator -(Polynom a, Polynom b)
        {
            int degree;
            double[] coefficients;
            if (a.Degree > b.Degree)
            {
                coefficients = new double[a.Сoefficients.Length];
                degree = a.Degree;
                for (int i = 0; i < b.Сoefficients.Length; ++i)
                {
                    coefficients[i] = a.Сoefficients[i] - b.Сoefficients[i];
                }
                for (int i = b.Сoefficients.Length; i < a.Сoefficients.Length; ++i)
                {
                    coefficients[i] = -a.Сoefficients[i];
                }
            }
            else
            {
                coefficients = new double[b.Сoefficients.Length];
                degree = b.Degree;
                for (int i = 0; i < a.Сoefficients.Length; ++i)
                {
                    coefficients[i] = a.Сoefficients[i] - b.Сoefficients[i];
                }
                for (int i = a.Сoefficients.Length; i < b.Сoefficients.Length; ++i)
                {
                    coefficients[i] = -b.Сoefficients[i];
                }
            }
            Polynom c = new Polynom(degree, coefficients);
            return c;
        }
        public static Polynom operator +(Polynom a, double number)
        {
            int degree = a.Degree;
            double[] coefficients = new double[a.Сoefficients.Length];
            for (int i = 0; i < a.Сoefficients.Length; i++)
            {
                coefficients[i] = a.Сoefficients[i];
                if (i == a.Сoefficients.Length - 1)
                    coefficients[i] = a.Сoefficients[i] + number;
            }
            return new Polynom(degree, coefficients);
        }
        public static Polynom operator -(Polynom a, double number)
        {
            int degree = a.Degree;
            double[] coefficients = new double[a.Сoefficients.Length];
            for (int i = 0; i < a.Сoefficients.Length; i++)
            {
                coefficients[i] = a.Сoefficients[i];
                if (i == a.Сoefficients.Length - 1)
                    coefficients[i] = a.Сoefficients[i] - number;
            }
            return new Polynom(degree, coefficients);
        }
        public static Polynom operator *(Polynom a, double number)
        {
            int degree = a.Degree;
            double[] coefficients = new double[a.Сoefficients.Length];
            for (int i = 0; i < a.Сoefficients.Length; i++)
            {
                coefficients[i] = a.Сoefficients[i] * number;
            }
            return new Polynom(degree, coefficients);
        }
        public static Polynom operator /(Polynom a, double number)
        {
            if (number == 0)
                throw new DivideByZeroException("you cannot dived on zero");
            int degree = a.Degree;
            double[] coefficients = new double[a.Сoefficients.Length];
            for (int i = 0; i < a.Сoefficients.Length; i++)
            {
                coefficients[i] = a.Сoefficients[i] / number;
            }
            return new Polynom(degree, coefficients);
        }
        public static Polynom operator *(Polynom a, Polynom b)
        {
            int itemsCount = a.Сoefficients.Length + b.Сoefficients.Length - 1;
            var coefficients = new double[itemsCount];
            for (int i = 0; i < a.Сoefficients.Length; i++)
            {
                for (int j = 0; j < b.Сoefficients.Length; j++)
                {
                    coefficients[i + j] += a.Сoefficients[i] * b.Сoefficients[j];
                }
            }
            return new Polynom(coefficients.Length-1, coefficients);
        }
        public static bool operator ==(Polynom a, Polynom b)
        {
            return (a.Сoefficients == b.Сoefficients) && (a.Degree == b.Degree);
        }
        public static bool operator !=(Polynom a, Polynom b)
        {
            return !(a == b);
        } 
        #endregion
        #region override methods
        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Polynom p = obj as Polynom;
            if ((System.Object)p == null)
            {
                return false;
            }
            if (Сoefficients.Length != p.Сoefficients.Length)
            {
                return false;
            }
            for (int i = 0; i < p.Сoefficients.Length; i++)
            {
                if (Сoefficients[i] != p.Сoefficients[i])
                {
                    return false;
                }
            }
            return true;
        }
        public override int GetHashCode()
        {
            return Degree.GetHashCode();
        }
        public override string ToString()
        {

            StringBuilder res = new StringBuilder();
            res.Append("Coefficients: ");
            int j = Сoefficients.Length - 1;
            for (int i = 0; i < Сoefficients.Length; i++)
            {
                if (i != Сoefficients.Length - 1)
                {
                    if (j == 1)
                    {
                        if (Math.Sign(Сoefficients[i]) == 1)
                            res.Append("+");
                        else
                            res.Append("-");
                        double number = Math.Abs(Сoefficients[i]);
                        res.Append(number);
                        res.Append("*x");
                        j--;
                    }
                    else
                    {
                        if (Math.Sign(Сoefficients[i]) == 1)
                            res.Append("+");
                        else
                            res.Append("-");
                        double number = Math.Abs(Сoefficients[i]);
                        res.Append(number);
                        res.Append("*x^");
                        res.Append(j);
                        j--;
                    }
                }
                else
                {
                    if (Math.Sign(Сoefficients[i]) == 1)
                        res.Append("+");
                    else
                        res.Append("-");
                    double number = Math.Abs(Сoefficients[i]);
                    res.Append(number);
                }
            }
            return res.ToString();
        } 
        #endregion
        #region private methods
        private void checkDegree(int deg)
        {
            if (deg < 0)
                throw new ArgumentOutOfRangeException("degree must be more than zero");
        }
        private void ckeckСoefficients(double[] coefficients)
        {
            if (coefficients.Length != (Degree + 1))
            {
                throw new ArgumentOutOfRangeException("you must write all coefficients");
            }
        } 
        #endregion
       
        
      
       

      
       
       
      
        
    }

}