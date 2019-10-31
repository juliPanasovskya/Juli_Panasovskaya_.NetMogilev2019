using Module_4;
using System;

namespace Module_4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool WaySortMinMax = true;
            ArrayMethods.EnterArraySize(out int n);
            ArrayMethods.CreateArrayInt(n, out int[] array);

            Console.Write("Choose the way of sort: \n 1 - Min to Max \n 2- Max to Min \n ");
            Parser.Parse(out char item);
            switch (item)
            {
                case '1':
                    WaySortMinMax = true;
                    break;
                case '2':
                    WaySortMinMax = false;
                    break;
                default:
                    Console.WriteLine("The wrong item!");
                    break;
            }
            ArrayMethods.SortArray(WaySortMinMax, array);
            ArrayMethods.DisplayArrayInt(array);
            Console.ReadKey();
        }
    }
}
