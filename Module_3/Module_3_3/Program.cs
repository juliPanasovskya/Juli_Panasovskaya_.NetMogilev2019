using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number FibonacciNumbers: ");
            int number = Convert.ToInt32(Console.ReadLine());
            FibonacсiNumbers(number);
            Console.ReadKey();
        }
        /// <summary>
        /// Finding N-amount Fibonacci Nuumbers
        /// n - current number
        /// m - past number
        /// z - summary n and m
        /// </summary>
        /// <param name="N"> Fibonacci Numbers </param>
        static void FibonacсiNumbers(int N)
        {
            int n = 0;
            int m = 1;
            int z=0;
            for (int i = 0; i < N ; i++)
            {
                Console.Write("{0} ", n);
                z = n + m;
                n = m;
                m = z;
                
            }


        }
    }
}
