using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestRateCalculator
{
    public class AccBalance
    {
       

        public static double accTotlBal()
        {
            // Static Balance used throughout, Randomly generated number between 1 and 999999 (Small figure used for testing purposes)
            Random randomNum = new Random();
            double accBal = 1 + (randomNum.NextDouble() * (1 * 999999));
            return Math.Round(accBal,2);
        }
    }
}
