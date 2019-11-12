using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, min, sum;
                     
            ArrayMethods.EnterArraySize(out int n);
            ArrayMethods.CreateArrayInt(n,out int[] array);      
            Console.WriteLine("Choose menu item:\n 1 - Max element; \n 2 - Min element; \n 3 - Sum elements; \n 4 - Difference (max - min) element; \n 5 - Even to increse to the max, odd reduce to the min; ");
            Parser.Parse(out char item);
            switch (item)
            {
                case '1':
                    ArrayMethods.GetMaxArrayEl(out max, array);
                    Console.WriteLine("max:{0} ", max);
                    break;
                case '2':
                    ArrayMethods.GetMinArrayEl(out min, array);
                    Console.WriteLine("min:{0} ", min);
                    break;
                case '3':
                    ArrayMethods.GetSumArrayEl(out sum,array);
                    Console.WriteLine("sum:{0} ", sum);
                    break;
                case '4':
                    ArrayMethods.GetMaxArrayEl(out max, array);
                    ArrayMethods.GetMinArrayEl(out min, array);
                    Console.WriteLine("dif:{0} ", ArrayMethods.GetDiffernceMaxMinArrayEl(max, min));
                    break;
                case '5':
                    Console.WriteLine("Base array:");
                    ArrayMethods.DisplayArrayInt(array);
                    Console.WriteLine();
                    Console.WriteLine("Changed array:");
                    ArrayMethods.GetMaxArrayEl(out max, array);
                    ArrayMethods.GetMinArrayEl(out min, array);
                    ArrayMethods.DisplayArrayInt(ArrayMethods.ChangeArrayEl(array, max, min));
                    break;
                default:
                    Console.WriteLine("The wrong item! Try to enter again.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
