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
        public double CheckVal(double accAmnt)
        {
            // Correct Interest amount to charge
            if (accAmnt > 0 && accAmnt < 1000)
                return 0.01;
            if (accAmnt >= 1000 && accAmnt < 5000)
                return 0.015;
            if (accAmnt >= 5000 && accAmnt < 10000)
                return 0.02;
            if (accAmnt >= 10000 && accAmnt < 50000)
                return 0.025;
            if (accAmnt >= 50000)
                return 0.03;
            else
                return 0; 
        }
        [TestMethod()]
        public void calculateIntrTest()
        {
            // Arrange 
            Random randomNum = new Random();
            double accBalance = AccBalance.accTotlBal();
            double interst = CheckVal(accBalance);

            InterestCalculator savingsAccountCalculator = new InterestCalculator();
            Double expctAccBalance = Math.Round((accBalance * interst), 2);
            // Act            
            double intersAmount = Math.Round(savingsAccountCalculator.calculateIntr(accBalance), 2);

            // Assert
            Assert.AreEqual(expctAccBalance, intersAmount);
        }
    }
}