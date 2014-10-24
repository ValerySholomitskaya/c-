using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EuclidsAlgorithm;

namespace EuclidsAlgorithmTest
{
    [TestClass]
    public class Gsd
    {
        [TestMethod]
        public void Gcd_WithTwoGoodNumbers()
        {
            // arrange
            long number1 = 3;
            long number2 = 6;
            long expected = 3;
            long time;
            // act
            long actual=GreatestCommonDivisor.Gcd(number1, number2,out time);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Gcd_WithTwoGoodNumber_AndZero()
        {
            // arrange
            long number1 = 3;
            long number2 = 0;
            long expected = 3;
            long time;
            // act
            long actual = GreatestCommonDivisor.Gcd(number1, number2, out time);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Gcd_WithThreeGoodNumbers()
        {
            // arrange
            long number1 = 3;
            long number2 = 6;
            int number3 = 7;
            long expected = 1;
            long time;
            // act
            long actual = GreatestCommonDivisor.Gcd(number1, number2,number3, out time);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Gcd_WithFourthGoodNumbers()
        {
            // arrange
            long number1 = 3;
            long number2 = 6;
            int number3 = -7;
            int number4 = 0;
            long expected = 1;
            long time;
            // act
            long actual = GreatestCommonDivisor.Gcd(out time,number1, number2, number3, number4);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BinaryGcd_WithFourthGoodNumbers()
        {
            // arrange
            long number1 = 3;
            long number2 = 6;
            int number3 = -7;
            int number4 = 0;
            long expected = 1;
            long time;
            // act
            long actual = GreatestCommonDivisor.BinaryGcd(out time, number1, number2, number3, number4);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BinaryGcd_WithTwoGoodNumbers()
        {
            // arrange
            long number1 = 3;
            long number2 = 6;
            long expected = 3;
            long time;
            // act
            long actual = GreatestCommonDivisor.BinaryGcd(number1, number2, out time);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BinaryGcd_WithTwoGoodNumber_AndZero()
        {
            // arrange
            long number1 = 3;
            long number2 = 0;
            long expected = 3;
            long time;
            // act
            long actual = GreatestCommonDivisor.BinaryGcd(number1, number2, out time);
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
