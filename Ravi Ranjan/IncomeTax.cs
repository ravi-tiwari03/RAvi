using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax
{
    class Program
    {
        static void Main(string[] args)
        {
            double Money;
            Console.WriteLine("Enter your Income:");
           Money = Convert.ToDouble(Console.ReadLine());
            double incomeTax;
            double RemainingFund;
            if (Money >= 0 && Money <= 250000)
            {
                incomeTax = 0;
            }
            else if (Money > 250000 && Money <= 500000)
            {
                incomeTax = Money * 0.05;
            }
            else if (Money > 500000 && Money <= 750000)
            {
                incomeTax = 250000 * 0.05 + (Money - 500000) * 0.1;
            }
            else if (Money > 750000 && Money <= 1000000)
            {
                incomeTax = 250000 * 0.05 + 250000 * 0.1 + (Money - 750000) * 0.15;
            }
            else if (Money > 1000000 && Money <= 1250000)
            {
                incomeTax = 250000 * 0.05 + 250000 * 0.1 + 250000 * 0.15 + (Money - 1000000) * 0.2;
            }
            else if (Money > 1250000 && Money <= 1500000)
            {
                incomeTax = 250000 * 0.05 + 250000 * 0.1 + 250000 * 0.15 + 250000 * 0.2 + (Money - 1250000) * 0.25;
            }
            else
            {
                incomeTax = 250000 * 0.05 + 250000 * 0.1 + 250000 * 0.15 + 250000 * 0.2 + 250000 * 0.25 + (Money - 1500000) * 0.3;
            }
            RemainingFund = Money - incomeTax;
            Console.WriteLine($"Total Tax : {incomeTax}");
            Console.WriteLine($"Remaining Fund : {RemainingFund}");
            Console.ReadLine();
        }
    }
}