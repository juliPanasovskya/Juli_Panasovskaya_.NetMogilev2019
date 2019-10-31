using System;

namespace Module_4_8
{
    public static class BisectionMethod
    {
        public static double FindResultOfFunction(double a, double b, double e)
        {
            double c;
            double Fa = Function(a); // F(a)
            c = (a + b) / 2;
            double Fc = Function(c); // F(c)
            if (Fa * Fc < 0)
            {
                b = c;
            }
            else
            {
                a = c;
            }
            if (Math.Abs(a - b) > e)
            {
                return FindResultOfFunction(a, b, e);
            }
            else
            {
                return c;
            }
        }
        static double Function(double x)
        {
            double Fx = Math.Pow(x, 3) - 3 * x + 1;//x^3-3x+1=0
            return Fx;
        }
    }
}
