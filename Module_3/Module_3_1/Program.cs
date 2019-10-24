using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}*{1}={2}",a,b,Multiply(a, b));
            Console.ReadKey();
        }
        static  int Multiply (int a, int b)
        {
            int result = 0;
            for (int i = 0; i < b; i++)
            {
                result =result + a;
            }
            

            return result;
        }
    }
}
