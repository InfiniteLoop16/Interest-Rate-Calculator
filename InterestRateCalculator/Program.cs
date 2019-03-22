using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestRateCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main: AccBal set to Staic Variable
            double accBal = AccBalance.accTotlBal();

            //Interest calculator instatiation
            InterestCalculator accCalBal = new InterestCalculator();

            // Write line with output value of interest.
            Console.WriteLine( "£" + accCalBal.calculateIntr(accBal).ToString() );
            Console.WriteLine("Please press enter to continue...");
            Console.ReadLine();
        }
    }
}
