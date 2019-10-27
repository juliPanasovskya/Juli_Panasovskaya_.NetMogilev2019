using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount of evens: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Evens(number);
            Console.ReadKey();
        }
        /// <summary>
        /// Finding N even numbers
        /// </summary>
        /// <param name="N"> Even numbers</param>
        static void Evens(int N)
        {
            int result = 0;
            for (int i = N; i < N+N; i++)
            {
                result = result + 2;
                Console.Write("{0} ", result);
            }


        }
    }
}
