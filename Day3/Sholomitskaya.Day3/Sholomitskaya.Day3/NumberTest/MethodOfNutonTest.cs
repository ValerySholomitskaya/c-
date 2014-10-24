using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Number;

namespace MethodOfNutonTest
{
    [TestClass]
    public class MethodOfNutonTest
    {
        [TestMethod]
        public void methodOfNuton()
        {
            double number = 16;
            int root = 2;
            double eps = 0.001;
            double expected = Math.Sqrt(number);
            // act
            double actual = Number.MethodOfNuton.methodOfNuton(number, root, eps);
            // assert
            Assert.AreEqual(expected, actual, eps);
        }
        [TestMethod]
        public void methodOfNutonWithRootMore2()
        {
            double number = 27;
            int root = 3;
            double eps = 0.001;
            double expected = 3;
            // act
            double actual = Number.MethodOfNuton.methodOfNuton(number, root, eps);
            // assert
            Assert.AreEqual(expected, actual, eps);
        }
        [TestMethod]
        public void methodOfNutonWithZeroNumber()
        {
            double number = 0;
            int root = 2;
            double eps = 0.001;
            double expected = 0;
            // act
            double actual = Number.MethodOfNuton.methodOfNuton(number, root, eps);
            // assert
            Assert.AreEqual(expected, actual, eps);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void methodOfNutonWithNumberLessZeroAndEvenRoot()
        {
            // arrange
            int number = -1;
            int root = 2;
            double eps = 0.001;
            // act
            double actual = Math.Round(Number.MethodOfNuton.methodOfNuton(number, root, eps), 2); ;
            // assert is handled by ExpectedException
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void methodOfNutonWithRootLessZero()
        {
            // arrange
            int number = 1;
            int root = -2;
            double eps = 0.001;
            // act
            double actual = Math.Round(Number.MethodOfNuton.methodOfNuton(number, root, eps), 2); ;
            // assert is handled by ExpectedException
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void methodOfNutonWithEpsLessZero()
        {
            // arrange
            int number = 1;
            int root = 2;
            double eps = -0.001;
            // act
            double actual = Math.Round(Number.MethodOfNuton.methodOfNuton(number, root, eps), 2); ;
            // assert is handled by ExpectedException
        }
    }
}
