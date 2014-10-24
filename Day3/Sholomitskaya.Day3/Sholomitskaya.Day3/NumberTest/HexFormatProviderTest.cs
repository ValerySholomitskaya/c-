using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Number;

namespace HexFormatProviderTest
{
    [TestClass]
    public class HexFormatProviderTest
    {
        [TestMethod]
        public void HexFormatProvidetTestWithBin()
        {
            // arrange
            int number = 1443;
            string expected = "5A3";
            IFormatProvider fp = new HexFormatProvider();
            // act
            string actual = string.Format(fp, "{0:Hex}", number);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BinaryFormatProvidetTestWithP()
        {
            // arrange
            int number = 1443;
            string expected = "1443";
            IFormatProvider fp = new HexFormatProvider();
            // act
            //string actual = Number.PRepresentationOfNumber.TransferredToAnotherNumberSystem(number, basis);
            string actual = string.Format(fp, "{0:D}", number);
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}