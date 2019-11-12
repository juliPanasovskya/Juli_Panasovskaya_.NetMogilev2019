using Module_4_3;
using Module_4;
using System;


namespace Module_4_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            (int a, int b, int c) values;
            Console.WriteLine("Enter a,b,c: ");
            Parser.Parse(out values.a);
            Parser.Parse(out values.b);
            Parser.Parse(out values.c);
            TupleMethods.IncreaseElement(ref values);
            Console.WriteLine("a={0}, b={1}, c={2}", values.a, values.b, values.c);
            Console.Write("Enter r: ");
            double r = double.Parse(Console.ReadLine());
            TupleMethods.GetCircleParams(r, out (double length, double square) parametr);
            Console.WriteLine("Length={0}, Square={1}", parametr.length, parametr.square);
            Console.Write("Enter size of array: ");
            ArrayMethods.EnterArraySize(out int n);
            ArrayMethods.CreateArrayInt(n, out int[] array);
            TupleMethods.GetArrayParams(out (int max, int min, int sum) arrayValues, array);
            Console.WriteLine("Max: {0}, Min: {1}, Sum:{2}", arrayValues.max, arrayValues.min, arrayValues.sum);
            Console.ReadKey();
        }

        
    }
}
