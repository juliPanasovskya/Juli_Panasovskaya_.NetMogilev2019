using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 1, 0, 4, 7, 5 };
            Console.Write("Base array: ");
            foreach (int item in array)
            {
                Console.Write("{0} ",item);
            }
            Console.Write("Max elements: ");
            DisplayMaxElement(array);
            Console.ReadKey();
        }
        static void DisplayMaxElement(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int j = i + 1;
                if (array[j] > array[i])
                {
                    Console.Write($" {array[j]} ");
                }
            }
        }
    }
}
