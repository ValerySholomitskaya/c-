using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Number;

namespace NumberTest
{
    [TestClass]
    public class pRepresentationOfNumberTest
    {
        [TestMethod]
        public void TransferredToAnotherNumberSystem_WithGoodNumberAndGoodBasis()
        {
            // arrange
            int number = 7;
            int basis=2;
            string expected = "111";
            pRepresentationOfNumber p = new pRepresentationOfNumber();
            // act
            p.SourceNumber = number;
            string actual=p.TransferredToAnotherNumberSystem(basis);
            // assert
            Assert.AreEqual(expected, actual);
        }
         [TestMethod]
         [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TransferredToAnotherNumberSystem_WithGoodNumber_WithBadBasis()
        {
            // arrange
            int number = 7;
            int basis = -2;
            pRepresentationOfNumber p = new pRepresentationOfNumber();
            // act
            p.SourceNumber = number;
            string actual = p.TransferredToAnotherNumberSystem(basis);
            // assert is handled by ExpectedException
        }
         [TestMethod]
         [ExpectedException(typeof(ArgumentOutOfRangeException))]
         public void TransferredToAnotherNumberSystem_WithBadNumber_WithGoodBasis()
         {
             // arrange
             int number = 7;
             int basis = -2;
             pRepresentationOfNumber p = new pRepresentationOfNumber();
             // act
             p.SourceNumber = number;
             string actual = p.TransferredToAnotherNumberSystem(basis);
             // assert is handled by ExpectedException
         }
    }
}
