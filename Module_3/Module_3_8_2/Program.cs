using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3_8_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter left border of the interval a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter rigth border of the interval b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter the calculation accuracy e: ");
            double e = double.Parse(Console.ReadLine());

            Console.Write("The solution to the equation x^3-3x+1=0");
            double c=0; // the half of interval
           

            do
            {
                double Fa = Function(a); // F(a)

                 c = (a + b) / 2;

                double  Fc = Function(c); // F(c)

                if (Fa*Fc<0)
                {
                   b = c;
               }
                else
                {
                    a = c;
                }

            }
            while (Math.Abs(a-b)>e); 

            Console.WriteLine("c={0}", c);

            Console.ReadKey();
        }
        /// <summary>
        /// Equation 
        /// </summary>
        /// <param name="x"> the root of equation </param>
        /// <returns> the result of equation </returns>

        static double Function(double x)
        {
            double Fx =Math.Pow(x,3)-3*x+1;
            return Fx;
        }
    }
}
