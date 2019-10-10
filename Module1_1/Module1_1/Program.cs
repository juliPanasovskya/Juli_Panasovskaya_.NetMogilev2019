using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c;
            c = a;
            a = b;
            b = c;

            Console.WriteLine("a={0}, b={1}",a.ToString(), b.ToString());
            Console.ReadLine();
        }
    }
}
