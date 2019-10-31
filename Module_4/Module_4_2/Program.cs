using Module_4;
using System;
namespace Module_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array, array1;
            int n, m;
            int sum;
            double sum2;
            string sum3;
            int[] sum1;
            int a, b, c;
            double d, e, f;
            string g, h;
            Console.WriteLine("Choose menu item: \n 1 -Sum 2 int; \n 2 - Sum 3 intt; \n 3 - Sum 3 float; \n 4 - sum 2 string; \n 5 - sum 2 arrays; ");
            char item = char.Parse(Console.ReadLine());
            switch (item)
            {
                case '1':
                    Console.WriteLine("Enter 2 numbers: ");
                    Parser.Parse(out a);
                    Parser.Parse(out b);
                    SumMethods.Sum(a, b, out sum);
                    Console.WriteLine("sum:{0} ", sum);
                    break;
                case '2':
                    Console.WriteLine("Enter 3 numbers: ");
                    Parser.Parse(out a);
                    Parser.Parse(out b);
                    Parser.Parse(out c);
                    SumMethods.Sum(a, b, c, out sum);
                    Console.WriteLine("sum:{0} ", sum);
                    break;
                case '3':
                    Console.WriteLine("Enter 3 double numbers: ");
                    Parser.Parse(out d);
                    Parser.Parse(out e);
                    Parser.Parse(out f);
                    SumMethods.Sum(d, e, f, out sum2);
                    Console.WriteLine("sum:{0} ", sum2);
                    break;
                case '4':
                    Console.WriteLine("Enter 2 strings: ");
                    g = Console.ReadLine();
                    h = Console.ReadLine();
                    SumMethods.Sum(g, h, out sum3);
                    Console.WriteLine("sum:{0} ", sum3);
                    break;
                case '5':
                    Console.Write("Enter size of array: ");
                    ArrayMethods.EnterArraySize(out n);
                    ArrayMethods.CreateArrayInt(n, out array);
                    Console.Write("Enter size of array1: ");
                    ArrayMethods.EnterArraySize(out m);
                    ArrayMethods.CreateArrayInt(m, out array1);
                    ArrayMethods.GetSumOfTwoArrays(out sum1, array, array1);
                    ArrayMethods.DisplayArrayInt(sum1);
                    break;
                default:
                    Console.WriteLine("The wrong item! Try to enter again.");
                    break;
            }
            Console.ReadLine();
        }






    }
}
