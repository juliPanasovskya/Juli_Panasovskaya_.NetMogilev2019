using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4_2
{
    public static class SumMethods
    {
        public static void Sum(int a, int b, out int sum)
        {
            sum = a + b;
        }
        public static void Sum(int a, int b, int c, out int sum)
        {
            sum = a + b + c;
        }
        public static void Sum(double d, double e, double f, out double sum)
        {
            sum = d + e + f;
        }
        public static void Sum(string a, string b, out string sum3)
        {
            sum3 = string.Concat(a, b);
        }
    }
}
