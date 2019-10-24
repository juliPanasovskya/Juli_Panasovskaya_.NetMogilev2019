using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount of companies: ");

            string amountOfCompanies = Console.ReadLine();

            Console.Write("Enter amount of rate: ");

            string rate = Console.ReadLine();

            decimal incomOfCompanies = 800.00M;

            decimal amountOfRateFromOneCompany = incomOfCompanies * Convert.ToDecimal(Convert.ToDouble(rate) / 100);

            decimal taxFromCompanies = Convert.ToInt32(amountOfCompanies) * amountOfRateFromOneCompany;

            Console.WriteLine("Summary tax for goverment:{0:####.##}", taxFromCompanies);

            Console.ReadKey();
        }
    }
}
