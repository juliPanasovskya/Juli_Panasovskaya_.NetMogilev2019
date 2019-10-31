using Module_4;
using System;
namespace Module_4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter left border of the interval a: ");
            Parser.Parse(out double a);
            Console.Write("Enter rigth border of the interval b: ");
            Parser.Parse(out double b);
            Console.Write("Enter the calculation accuracy e: ");
            Parser.Parse(out double c);
            Console.Write("The solution to the equation x^3-3x+1=0 \n");
            Console.WriteLine(" c={0}", c);
            Console.ReadKey();
        }
        
    }
}
