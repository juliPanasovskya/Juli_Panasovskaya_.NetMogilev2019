using System;

namespace Module_4_3
{
    public static class Methods
    {
        public static void IncreaseElement(ref int a, ref int b, ref int c)
        {
            a += 10;
            b += 10;
            c += 10;
        }
        public static void CircleParams(double r, out double length, out double square)
        {
            length = Math.Round(2 * r * Math.PI, 3);
            square = Math.Round(Math.PI * Math.Pow(r, 2), 3);
        }

        
        
    }
}
