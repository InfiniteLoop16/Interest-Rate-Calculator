using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterestRateCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestRateCalculator.Tests
{
    [TestClass()]
    public class InterestCalculatorTests
    {

        // Arrange
        InterestCalculator interestCacl = new InterestCalculator();

        [TestMethod()]
        public void ClassConstructor()
        {
            //Act
            Assert.IsNotNull(interestCacl);
        }

        [TestMethod()]
        public void PassPositiveBalanceReturnsAValue()
        {
            // Act
            double interest = interestCacl.calculateIntr(1000);
            // Assert
            Assert.IsNotNull(interest);
        }

        [TestMethod()]
        public void PassNegativeBalanceReturnsZero()
        {
            // Act
            double interest = interestCacl.calculateIntr(-650);
            // Assert
            Assert.AreEqual(interest, 0.0);
        }

        [TestMethod()]
        public void PassBalanceForOnePercentInterest()
        {
            // Arrange
            double bankBal = 100;
            double expectedAmount = 1;

            //Act 
            double interestAmount = interestCacl.calculateIntr(bankBal);

            // Aseert
            Assert.AreEqual(expectedAmount, interestCacl.calculateIntr(bankBal), 0.001);

        }

        [TestMethod()]
        public void PassBalanceForOnePointFivePercentInterest()
        {
            // Arrange
            double bankBal = 3560.10;
            double expectedAmount = 53.40;

            //Act 
            double interestAmount = interestCacl.calculateIntr(bankBal);

            // Assert
            Assert.AreEqual(expectedAmount, interestCacl.calculateIntr(bankBal), 0.001);
        }


        [TestMethod()]
        public void PassBalanceForTwoPercentInterest()
        {
            // Arrange
            double bankBal = 7865.32;
            double expectedAmount = 157.31;

            //Act 
            double interestAmount = interestCacl.calculateIntr(bankBal);

            // Assert
            Assert.AreEqual(expectedAmount, interestAmount, 0.001);
        }

        [TestMethod()]
        public void PassBalanceForTwoPointFivePercentInterest()
        {
            // Arrange
            double bankBal = 22000;
            double expectedAmount = 550;

            //Act 
            double interestAmount = interestCacl.calculateIntr(bankBal);

            // Assert
            Assert.AreEqual(expectedAmount, interestCacl.calculateIntr(bankBal), 0.001);
        }

        [TestMethod()]
        public void PassBalanceForThreePercentInterest()
        {
            // Arrange
            double bankBal = 98256.35;
            double expectedAmount = 2947.69;

            //Act 
            double interestAmount = interestCacl.calculateIntr(bankBal);

            // Assert
            Assert.AreEqual(expectedAmount, interestCacl.calculateIntr(bankBal), 0.001);
        }

    }
}