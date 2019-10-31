using Module_4;
using System;

namespace Module_4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayMethods.EnterArraySize(out int n);
            ArrayMethods.CreateArrayInt(n, out int[] array);
            ArrayMethods.GetArrayElAddFive(array);
            ArrayMethods.DisplayArrayInt(array);
            Console.ReadKey();
        }
    }
}
