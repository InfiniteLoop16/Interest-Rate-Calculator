using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestRateCalculator
{
    public class InterestCalculator
    {
        // Private variable returned by calculateIntr method
        private double intrAmnt = 0;

        //Method to calculate interst charged
        public Double calculateIntr(double accBal)        {


            //If the account balance is less than 1000 then 1% interest is charged
            if (accBal > 0 && accBal < 1000)
                intrAmnt = accBal * 0.01;
            //If the account balance is greater or equal to 1000 but less than 5000 then 1.5% interest is charged
            if (accBal >= 1000 && accBal < 5000)
                intrAmnt = accBal * 0.015;
            //If the account balance is greater or equal to 5000 but less than 10000 then 1.5% interest is charged
            if (accBal >= 5000 && accBal < 10000)
                intrAmnt = accBal * 0.02;
            //If the account balance is greater or equal to 10000 but less than 50000 then 1.5% interest is charged
            if (accBal >= 10000 && accBal < 50000)
                intrAmnt = accBal * 0.025;
            //If the account balance is greater or equal to 50000 then 3% interest is charged
            if (accBal >= 50000)
                intrAmnt = accBal * 0.03;

            return Math.Round(intrAmnt,2);
        }
    }
}
