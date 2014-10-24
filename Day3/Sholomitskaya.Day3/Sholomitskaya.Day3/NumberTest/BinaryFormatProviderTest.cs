using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Number;

namespace BinaryFormatProviderTest
{
    [TestClass]
    public class BinaryFormatProviderTest
    {
        [TestMethod]
        public void BinaryFormatProvidetTestWithBin()
        {
            // arrange
            int number = 7;
            string expected = "111";
            IFormatProvider fp = new BinaryFormatProvider();
            // act
            string actual = string.Format(fp, "{0:Bin}", number);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BinaryFormatProvidetTestWithD()
        {
            // arrange
            int number = 7;
            string expected = "7";
            IFormatProvider fp = new BinaryFormatProvider();
            // act
            //string actual = Number.PRepresentationOfNumber.TransferredToAnotherNumberSystem(number, basis);
            string actual = string.Format(fp, "{0:D}", number);
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}