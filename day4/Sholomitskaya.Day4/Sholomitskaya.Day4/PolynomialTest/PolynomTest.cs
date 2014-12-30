using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolynomialTest
{
    [TestClass]
    public class PolynomTest
    {
        [TestMethod]
        public void CreatePolynomWithDegreeGreateerZeroAndCoefficientsEqualDegreePlusOne()
        {
            int degree = 3;
            double[] coeff = new double[] { 3, 4, -5, 7 };
            string expected = "+3*x^3+4*x^2-5*x+7";
            // act
            Polynomial.Polynom actual = new Polynomial.Polynom(degree, coeff);
             // assert
            StringAssert.Equals(expected, actual.ToString());
        }
        [TestMethod]
        public void TestCalculate()
        {
            int degree = 2;
            double[] coeff = new double[] { 3, 4, -5 };
            int x = 1;
            int expected=2;
            // act
            Polynomial.Polynom actual = new Polynomial.Polynom(degree, coeff);
            // assert
            Assert.AreEqual(expected, actual.Calculate(x));
        }
        [TestMethod]
        public void TestoverloadedOperatorPlusPolynom()
        {
            int degree1 = 2;
            double[] coeff1 = new double[] { 3, 4, -5 };
            int degree2 = 3;
            double[] coeff2 = new double[] { 3,0, 9,3 };
            string expected = "+3*x^3+3*x^2-13*x-2";
            // act
            Polynomial.Polynom a = new Polynomial.Polynom(degree1, coeff1);
            Polynomial.Polynom b = new Polynomial.Polynom(degree2, coeff2);
            String actual = (a + b).ToString();
            // assert
            StringAssert.Equals(expected, actual);
        }
        [TestMethod]
        public void TestoverloadedOperatorMinusPolynom()
        {
            int degree1 = 2;
            double[] coeff1 = new double[] { 3, 4, -5 };
            int degree2 = 3;
            double[] coeff2 = new double[] { 3, 0, 9, 3 };
            string expected = "-3*x^3-3*x^2+5*x+8";
            // act
            Polynomial.Polynom a = new Polynomial.Polynom(degree1, coeff1);
            Polynomial.Polynom b = new Polynomial.Polynom(degree2, coeff2);
            String actual = (a - b).ToString();
            // assert
            StringAssert.Equals(expected, actual);
        }
        [TestMethod]
        public void TestoverloadedOperatorMultiplyPolynom()
        {
            int degree1 = 1;
            double[] coeff1 = new double[] { 3,5 };
            int degree2 = 1;
            double[] coeff2 = new double[] { 3, 5 };
            string expected = "+9*x^2+30*x+25";
            // act
            Polynomial.Polynom a = new Polynomial.Polynom(degree1, coeff1);
            Polynomial.Polynom b = new Polynomial.Polynom(degree2, coeff2);
            String actual = (a * b).ToString();
            // assert
            StringAssert.Equals(expected, actual);
        }
        [TestMethod]
        public void TestoverloadedOperatorEqualsPolynom()
        {
            int degree1 = 1;
            double[] coeff1 = new double[] { 3, 5 };
            bool expected = true;
            // act
            Polynomial.Polynom a = new Polynomial.Polynom(degree1, coeff1);
            Polynomial.Polynom b =a;
            bool actual = (a==b);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestoverloadedOperatorNotEqualsPolynom()
        {
            int degree1 = 1;
            double[] coeff1 = new double[] { 3, 5 };
            bool expected = false;
            // act
            Polynomial.Polynom a = new Polynomial.Polynom(degree1, coeff1);
            Polynomial.Polynom b = a;
            bool actual = (a != b);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestoverloadedOverloadedEqualsPolynom()
        {
            int degree1 = 1;
            double[] coeff1 = new double[] { 3, 5 };
            int degree2 = 1;
            double[] coeff2 = new double[] { 3, 5 };
            bool expected = true;
            // act
            Polynomial.Polynom a = new Polynomial.Polynom(degree1, coeff1);
            Polynomial.Polynom b = new Polynomial.Polynom(degree2, coeff2);
            bool actual = (a.Equals(b));
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestoverloadedOperatorMinusNumber()
        {
            int degree1 = 2;
            double[] coeff1 = new double[] { 3, 4, -5 };
            int number = 3;
            string expected = "+3*x^2+4*x-8";
            // act
            Polynomial.Polynom a = new Polynomial.Polynom(degree1, coeff1);
            String actual = (a - number).ToString();
            // assert
            StringAssert.Equals(expected, actual);
        }
        [TestMethod]
        public void TestoverloadedOperatorPlusNumber()
        {
            int degree1 = 2;
            double[] coeff1 = new double[] { 3, 4, -5 };
            int number = 10;
            string expected = "+3*x^2+4*x+5";
            // act
            Polynomial.Polynom a = new Polynomial.Polynom(degree1, coeff1);
            String actual = (a+number).ToString();
            // assert
            StringAssert.Equals(expected, actual);
        }
        [TestMethod]
        public void TestoverloadedOperatorMultiplicateNumber()
        {
            int degree1 = 2;
            double[] coeff1 = new double[] { 3, 4, -5 };
            int number = 10;
            string expected = "+30*x^2+40*x-50";
            // act
            Polynomial.Polynom a = new Polynomial.Polynom(degree1, coeff1);
            String actual = (a*number).ToString();
            // assert
            StringAssert.Equals(expected, actual);
        }
        [TestMethod]
        public void TestoverloadedOperatorDivideNumber()
        {
            int degree1 = 2;
            double[] coeff1 = new double[] { 3, 4, -5 };
            int number = 10;
            string expected = "+0.3*x^2+0.4*x-0.5";
            // act
            Polynomial.Polynom a = new Polynomial.Polynom(degree1, coeff1);
            String actual = (a * number).ToString();
            // assert
            StringAssert.Equals(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreatePolynomWithDegreeLessZeroAndCoefficientsEqualDegreePlusOne()
        {
            // arrange
            int degree = -3;
            double[] coeff = new double[] { 3, 4, -5, 7 };
            // act
            Polynomial.Polynom actual = new Polynomial.Polynom(degree, coeff);
            // assert is handled by ExpectedException
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreatePolynomWithDegreeGreaterZeroAndCoefficientsNotEqualDegreePlusOne()
        {
            // arrange
            int degree = -3;
            double[] coeff = new double[] { 3, 4, -5 };
            // act
            Polynomial.Polynom actual = new Polynomial.Polynom(degree, coeff);
            // assert is handled by ExpectedException
        }
    }
}
