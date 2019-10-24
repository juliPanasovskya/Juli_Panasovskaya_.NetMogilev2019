using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 0, -1, 2, -4, 6, 7 };
            Console.Write("Base array: ");
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.Write("Swap array: ");
            foreach (int item in SwapSign(array))
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }
        static int[] SwapSign(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = 0 - Math.Abs(array[i]);
                }
                else if (array[i] < 0)
                {
                    array[i] = Math.Abs(array[i]);
                }
                else
                {
                    array[i] = 0;
                }
            }
            return array;
        }
    }
}
