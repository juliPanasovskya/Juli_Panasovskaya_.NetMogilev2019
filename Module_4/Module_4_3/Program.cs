using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_4;

namespace Module_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a,b,c: ");
            Parser.Parse(out int a);
            Parser.Parse(out int b);
            Parser.Parse(out int c);
            Methods.IncreaseElement(ref a, ref b, ref c);
            Console.WriteLine("a={0}, b={1}, c={2}", a, b, c);
            Console.Write("Enter r: ");
            double r = double.Parse(Console.ReadLine());
            Methods.CircleParams(r, out double length, out double square);
            Console.WriteLine("Length={0}, Square={1}", length, square);
            Console.Write("Enter size of array: ");
            ArrayMethods.EnterArraySize(out int n);
            ArrayMethods.CreateArrayInt(n, out int[] array);
            ArrayMethods.GetArrayParams(out int max, out int min, out int sum, array);
            Console.WriteLine("Max: {0}, Min: {1}, Sum:{2}", max, min, sum);
            Console.ReadKey();
        }
    }
}
